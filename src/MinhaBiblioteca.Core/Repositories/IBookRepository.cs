using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repositories;

public interface IBookRepository
{
    Task CreateAsync(Book book);
    Task<Book> GetByIdAsync(Guid id);
    Task<Book> GetByNameAsync(string name);
    Task<Book> GetByIsbnAsync(string isbn);
    Task<IEnumerable<Book>> GetBooksAsync();
    Task Update(Book book);
    Task Delete(Book book);
}
