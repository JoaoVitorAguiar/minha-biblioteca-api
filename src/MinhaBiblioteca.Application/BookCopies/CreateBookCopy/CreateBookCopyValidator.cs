using FluentValidation;

namespace MinhaBiblioteca.Application.BookCopies;

public class CreateBookCopyValidator : AbstractValidator<CreateBookCopyCommand>
{
    public CreateBookCopyValidator()
    {
        RuleFor(x => x.Isbn)
            .NotEmpty().WithMessage("ISBN is required.")
            .Length(13).WithMessage("ISBN must be 13 characters long.")
            .Matches(@"^\d+$").WithMessage("ISBN must be a numeric value.");
    }
}