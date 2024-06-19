namespace MinhaBiblioteca.Core.Entities;

public class Book : BaseEntity
{
    public Book(string title, string iSBN, DateTime publishedDate, int amount)
    {
        Title = title;
        ISBN = iSBN;
        PublishedDate = publishedDate;
        Amount = amount;

        Loans = [];
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public string Title { get; private set; }
    public string ISBN { get; private set; }
    public DateTime PublishedDate { get; private set; }
    public int Amount { get; private set; }

    public ICollection<Loan> Loans { get; private set; }
}
