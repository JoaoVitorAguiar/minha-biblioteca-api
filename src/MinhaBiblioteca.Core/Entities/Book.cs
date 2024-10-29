namespace MinhaBiblioteca.Core.Entities;

public class Book : BaseEntity
{
    public Book() { }
    public Book(string title, string iSBN, string author, DateTime publishedDate, Guid categoryId)
    {
        Id = Guid.NewGuid();
        Title = title;
        ISBN = iSBN;
        Author = author;
        PublishedDate = publishedDate;
        CategoryId = categoryId;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        BookCopies = [];
    }

    public string Title { get; private set; }
    public string ISBN { get; private set; }
    public string Author { get; private set; }
    public DateTime PublishedDate { get; private set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; private set; }
    public IList<BookCopy> BookCopies { get; private set; }
}
