using MediatR;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Exceptions;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Application.Books.Queries.GetBookByISBN;

public class GetBookByISBNQueryHandler : IRequestHandler<GetBookByISBNQuery, GetBookByISBNQueryDTO>
{
    private readonly IBookRepository _bookRepository;

    public GetBookByISBNQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<GetBookByISBNQueryDTO> Handle(GetBookByISBNQuery request, CancellationToken cancellationToken)
    {
        var book = await _bookRepository.GetByIsbnAsync(request.ISBN) ?? throw new NotFoundException(typeof(Book));
        return new GetBookByISBNQueryDTO
        {
            Title = book.Title,
            Author = book.Author
        };
    }
}
