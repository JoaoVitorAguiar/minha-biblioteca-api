namespace MinhaBiblioteca.Core.Entities;

public class Loan : BaseEntity
{
    public Loan() { }
    public Loan(Guid userId, Guid bookCopyId, DateTime? returnDate)
    {
        Id = Guid.NewGuid();
        ReturnDate = returnDate;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;

        UserId = userId;
        BookCopyId = bookCopyId;
    }

    public DateTime? ReturnDate { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
    public Guid BookCopyId { get; private set; }
    public BookCopy BookCopy { get; private set; }

    public void ReturnLoan()
    {
        this.ReturnDate = DateTime.UtcNow;
    }
}
