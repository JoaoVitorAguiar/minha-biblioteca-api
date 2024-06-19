namespace MinhaBiblioteca.Core.Entities;

public class Loan : BaseEntity
{
    public Loan(DateTime loanDate, DateTime? returnDate, Guid userId, Guid bookId)
    {
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
}
