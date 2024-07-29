using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Infrastructure.Repositories;

public class LoanRepository : ILoanRepository
{
    private readonly MinhaBibliotecaDbContext _dbContext;

    public LoanRepository(MinhaBibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Loan> CreateAsync(Loan loan)
    {
        await _dbContext.Loans.AddAsync(loan);
        await _dbContext.SaveChangesAsync();
        return loan;
    }

    public async Task<Loan> DeleteAsync(Loan loan)
    {
        _dbContext.Loans.Remove(loan);
        await _dbContext.SaveChangesAsync();
        return loan;
    }

    public async Task<IList<Loan>> GetAllAsync()
    {
        return await _dbContext.Loans.ToListAsync();
    }

    public async Task<Loan?> GetAsync(Guid id)
    {
        return await _dbContext.Loans.FindAsync(id);
    }

    public async Task<Loan> UpdateAsync(Loan loan)
    {
        _dbContext.Loans.Update(loan);
        await _dbContext.SaveChangesAsync();
        return loan;
    }
}
