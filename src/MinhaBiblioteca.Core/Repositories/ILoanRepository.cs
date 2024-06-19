using MinhaBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Core.Repositories;

public interface ILoanRepository
{
    Task<IEnumerable<Loan>> GetByBookAsync(Book book);
    Task<Loan> GetByIdAsync(Guid id);
    Task<IEnumerable<Loan>> GetByUserAsync(User user);
    Task<IEnumerable<Loan>> GetLoansAsync();
    Task LendAsync(Loan loan);
    Task ReturnAsync(Loan loan);
}
