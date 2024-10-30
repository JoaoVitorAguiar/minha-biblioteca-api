using MediatR;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Application.Books;

public class GetAllBooksQuery : IRequest<List<Book>>
{

}