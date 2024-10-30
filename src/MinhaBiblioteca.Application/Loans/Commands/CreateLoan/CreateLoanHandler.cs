using MediatR;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Exceptions;
using MinhaBiblioteca.Core.Repositories;
using MinhaBiblioteca.Core.Services;

namespace MinhaBiblioteca.Application.Loans.Commands.CreateLoan;

public class CreateLoanHandler : IRequestHandler<CreateLoanCommand, Unit>
{
    private readonly IUserRepository _userRepository;
    private readonly ILoanRepository _loanRepository;
    private readonly IBookService _bookService;
    private readonly IBookRepository _bookRepository;

    public CreateLoanHandler(IUserRepository userRepository, ILoanRepository loanRepository, IBookService bookService, IBookRepository bookRepository)
    {
        _userRepository = userRepository;
        _loanRepository = loanRepository;
        _bookService = bookService;
        _bookRepository = bookRepository;
    }

    public async Task<Unit> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(request.UserEmail) ?? throw new NotFoundException(typeof(User));
        var book = await _bookRepository.GetByIsbnAsync(request.ISBN) ?? throw new NotFoundException(typeof(Book));
        var bookCopy = await _bookService.GetFirstBookCopyAvailableByIsbnOrDefaultAsync(book) ?? throw new NotAvailableException(typeof(BookCopy));
        var loan = new Loan(user.Id, bookCopy.Id, null);
        await _loanRepository.CreateAsync(loan);
        return Unit.Value;
    }
}
