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

    public CreateLoanHandler(IUserRepository userRepository, ILoanRepository loanRepository, IBookService bookService)
    {
        _userRepository = userRepository;
        _loanRepository = loanRepository;
        _bookService = bookService;
    }

    public async Task<Unit> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(request.UserEmail) ?? throw new NotFoundException(typeof(User));
        var book = await _bookService.GetFirstBookAvailableByIsbnOrDefaultAsync(request.ISBN) ?? throw new NotAvailableException(typeof(Book));
        var loan = new Loan(request.LoanDate, null, user.Id, book.Id);
        await _loanRepository.CreateAsync(loan);
        return Unit.Value;
    }
}
