using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Application.Books.Commands.CreateBookCommand;

public class CreateBookCommand: IRequest<Unit>
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public Guid CategoryId { get; set; }
}
