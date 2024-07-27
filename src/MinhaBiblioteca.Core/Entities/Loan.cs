using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Core.Entities;

public class Loan : BaseEntity
{
    public Loan() { }
    public Loan(DateTime loanDate, DateTime? returnDate, Guid userId, Guid bookId)
    {
        Id = Guid.NewGuid();
        LoanDate = loanDate;
        ReturnDate = returnDate;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;

        UserId = userId;
        BookId = bookId;
    }

    public DateTime LoanDate { get; private set; }
    public DateTime? ReturnDate { get; private set; }

    public Guid UserId { get; private set; }
    public Guid BookId { get; private set; }

    public User User { get; private set; }
    public Book Book { get; private set; }

    public void ReturnLoan()
    {
        this.ReturnDate = DateTime.UtcNow;
    }
}
