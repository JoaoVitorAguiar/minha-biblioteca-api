using MinhaBiblioteca.Core.Entities;
namespace MinhaBiblioteca.Core.Repositories;

public interface ILoanRepository
{
    Task Lend(Loan loan);
    Task<Loan> GetById(Guid id);
    Task<IEnumerable<Loan>> GetByUser(User user);
    Task<IEnumerable<Loan>> GetByBook(Book book);
    Task<IEnumerable<Loan>> GetLoans();
    Task Return(Loan loan);
}