namespace MinhaBiblioteca.Core.Entities;

public class Book: BaseEntity
{
    public Book(string title, string iSBN, DateTime publishedDate, int amount)
    {
        Title = title;
        ISBN = iSBN;
        PublishedDate = publishedDate;
        Amount = amount;
        
        Loans = [];
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public string Title { get; private set; }
    public string ISBN { get; private set; }
    public DateTime PublishedDate { get; private set; }
    public int Amount { get; private set; }

    public List<Loan> Loans { get; private set; }
}
