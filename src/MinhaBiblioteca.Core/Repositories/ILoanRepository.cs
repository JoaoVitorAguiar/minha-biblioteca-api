using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repositories;

public interface ILoanRepository
{
    Task<Loan> CreateAsync(Loan loan);
    Task<Loan> UpdateAsync(Loan loan);
    Task<Loan> DeleteAsync(Loan loan); 
    Task<Loan?> GetAsync(Guid id);
    Task<IList<Loan>> GetAllAsync();
}
