using MediatR;

namespace MinhaBiblioteca.Application.Books.Commands.CreateBook;

public class CreateBookCommand : IRequest<Unit>
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public Guid CategoryId { get; set; }
}
