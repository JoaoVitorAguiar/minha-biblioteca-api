using MinhaBiblioteca.Core.Entities;
namespace MinhaBiblioteca.Core.Repositories;

public interface ILoanRepository
{
    void Lend(Loan loan);
    Loan GetById(Guid id);
    IEnumerable<Loan> GetByUser(User user);
    IEnumerable<Loan> GetByBook(Book book);
    IEnumerable<Loan> GetLoans();
    void Return(Loan loan);
}