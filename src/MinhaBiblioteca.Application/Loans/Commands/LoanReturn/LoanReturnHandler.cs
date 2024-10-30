using MediatR;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Exceptions;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Application.Loans;

public class LoanReturnHandler : IRequestHandler<LoanReturn, Unit>
{
    private readonly ILoanRepository _loanRepository;

    public LoanReturnHandler(ILoanRepository loanRepository)
    {
        _loanRepository = loanRepository;
    }

    public async Task<Unit> Handle(LoanReturn request, CancellationToken cancellationToken)
    {
        var loan = await _loanRepository.GetAsync(request.Id) ?? throw new NotFoundException(typeof(User));
        if (loan.ReturnDate != null) return Unit.Value;
        loan.ReturnLoan();
        await _loanRepository.UpdateAsync(loan);
        return Unit.Value;
    }
}
