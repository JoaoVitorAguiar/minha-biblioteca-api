using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repositories;

public interface IBookRepository
{
    Task<Book> CreateAsync(Book book);
    Task<Book> UpdateAsync(Book book);
    Task<Book> DeleteAsync(Book book);
    Task<Book?> GetByIdAsync(Guid id);
    Task<Book?> GetByISBNAsync(string isbn);
    Task<IList<Book>> GetAllAsync();
}
