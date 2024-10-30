using MediatR;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Exceptions;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Application.BookCopies;

public class CreateBookCopiesHandler : IRequestHandler<CreateBookCopyCommand, Unit>
{
    private readonly IBookCopyRepository _bookCopyRepository;
    private readonly IBookRepository _bookRepository;

    public CreateBookCopiesHandler(IBookCopyRepository bookCopyRepository, IBookRepository bookRepository)
    {
        _bookCopyRepository = bookCopyRepository;
        _bookRepository = bookRepository;
    }

    public async Task<Unit> Handle(CreateBookCopyCommand request, CancellationToken cancellationToken)
    {
        var book = await _bookRepository.GetByIsbnAsync(request.Isbn) ?? throw new NotFoundException(typeof(Book));
        var bookCopy = new BookCopy(book.Id);
        await _bookCopyRepository.CreateAsync(bookCopy);
        return Unit.Value;
    }
}
