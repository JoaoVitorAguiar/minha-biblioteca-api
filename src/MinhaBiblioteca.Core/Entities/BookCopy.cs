namespace MinhaBiblioteca.Core.Entities;

public class BookCopy : BaseEntity
{
    public BookCopy() { }
    public BookCopy(Guid bookId)
    {
        Id = Guid.NewGuid();
        BookId = bookId;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    public Guid BookId { get; set; }
    public Book Book { get; private set; }
    public IList<Loan> Loan { get; set; }

}
