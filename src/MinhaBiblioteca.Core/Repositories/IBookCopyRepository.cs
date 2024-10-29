using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repositories;

public interface IBookCopyRepository
{
    Task<BookCopy> CreateAsync(BookCopy bookCopy);
    Task<BookCopy> UpdateAsync(BookCopy bookCopy);
    Task<BookCopy> DeleteAsync(BookCopy bookCopy);
    Task<BookCopy?> GetByIdAsync(Guid id);
    Task<IList<BookCopy>> GetAllAsync();
}