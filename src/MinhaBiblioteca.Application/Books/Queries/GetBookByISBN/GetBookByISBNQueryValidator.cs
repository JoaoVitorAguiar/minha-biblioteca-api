using FluentValidation;

namespace MinhaBiblioteca.Application.Books.Queries.GetBookByISBN;

public class GetBookByISBNQueryValidator : AbstractValidator<GetBookByISBNQuery>
{
    public GetBookByISBNQueryValidator()
    {
        RuleFor(r => r.ISBN).NotEmpty().NotNull().Length(13);
    }
}
