using MediatR;

namespace MinhaBiblioteca.Application.BookCopies;

public class CreateBookCopyCommand : IRequest<Unit>
{
    public string Isbn { get; set; }
}

