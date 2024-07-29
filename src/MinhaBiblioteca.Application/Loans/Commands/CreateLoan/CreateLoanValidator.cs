using FluentValidation;

namespace MinhaBiblioteca.Application.Loans.Commands.CreateLoan;

public class CreateLoanValidator : AbstractValidator<CreateLoanCommand>
{
    public CreateLoanValidator()
    {
        RuleFor(x => x.LoanDate)
               .NotEmpty().WithMessage("Loan date is required.")
               .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Loan date cannot be in the future.");

        RuleFor(x => x.UserEmail)
            .NotEmpty().WithMessage("User email is required.")
            .EmailAddress().WithMessage("A valid email address is required.");

        RuleFor(x => x.ISBN)
            .NotEmpty().WithMessage("ISBN is required.")
            .Length(13).WithMessage("ISBN must be 13 characters long.")
            .Matches(@"^\d+$").WithMessage("ISBN must be a numeric value.");
    }
}
