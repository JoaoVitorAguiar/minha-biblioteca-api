using MediatR;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Application.Books;

public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<Book>>
{
    private readonly IBookRepository _bookRepository;

    public GetAllBooksQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var result = await _bookRepository.GetAllAsync();
        return result.ToList();
    }
}