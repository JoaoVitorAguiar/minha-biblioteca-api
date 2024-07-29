using MediatR;

namespace MinhaBiblioteca.Application.Books.Queries.GetBookByISBN;

public class GetBookByISBNQuery : IRequest<GetBookByISBNQueryDTO>
{
    public string ISBN { get; set; }
}
