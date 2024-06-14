using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repositories;

public interface IBookRepository
{
    void Create(Book book);
    Book GetById(Guid id);
    Book GetByName(string name);
    Book GetByIsbn(string isbn);
    IEnumerable<Book> GetBooks();
    void Update(Book book);
    void Delete(Book book);
}
