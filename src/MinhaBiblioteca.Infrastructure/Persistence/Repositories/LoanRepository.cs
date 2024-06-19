using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Infrastructure.Persistence.Repositories;

public class LoanRepository : ILoanRepository
{
    private readonly MinhaBibliotecaDbContext _dbContext;

    public LoanRepository(MinhaBibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Loan>> GetByBookAsync(Book book)
    {
        return await _dbContext.Loans
            .Where(loan => loan.BookId == book.Id)
            .ToListAsync();
    }

    public async Task<Loan> GetByIdAsync(Guid id)
    {
        return await _dbContext.Loans
            .FirstOrDefaultAsync(loan => loan.Id == id);
    }

    public async Task<IEnumerable<Loan>> GetByUserAsync(User user)
    {
        return await _dbContext.Loans
            .Where(loan => loan.UserId == user.Id)
            .ToListAsync();
    }

    public async Task<IEnumerable<Loan>> GetLoansAsync()
    {
        return await _dbContext.Loans
            .ToListAsync();
    }

    public async Task LendAsync(Loan loan)
    {
        await _dbContext.Loans.AddAsync(loan);
        await _dbContext.SaveChangesAsync();
    }

    public async Task ReturnAsync(Loan loan)
    {
        loan.ReturnLoan();
        _dbContext.Loans.Update(loan);
        await _dbContext.SaveChangesAsync();
    }
}
