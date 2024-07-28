
using FluentValidation;

namespace MinhaBiblioteca.Application.Books.Commands.CreateBook;

public class CreateBookValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookValidator()
    {
        RuleFor(r => r.Title).NotEmpty().NotNull().MinimumLength(3);
        RuleFor(r => r.ISBN).NotEmpty().NotNull().Length(13);
        RuleFor(r => r.Author).NotEmpty().NotNull().MinimumLength(3);
        RuleFor(r => r.PublishedDate).NotNull();
        RuleFor(r => r.CategoryId).NotEmpty().NotNull();
    }
}