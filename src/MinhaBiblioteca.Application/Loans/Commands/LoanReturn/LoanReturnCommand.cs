using MediatR;

namespace MinhaBiblioteca.Application.Loans;

public class LoanReturn : IRequest<Unit>
{
    public Guid Id { get; set; }
}