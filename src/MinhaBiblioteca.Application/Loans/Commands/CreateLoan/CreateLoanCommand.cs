using MediatR;

namespace MinhaBiblioteca.Application.Loans.Commands.CreateLoan;

public class CreateLoanCommand: IRequest<Unit>
{
    public DateTime LoanDate { get; set; }
    public string UserEmail { get; set; }
    public string ISBN { get; set; }

}