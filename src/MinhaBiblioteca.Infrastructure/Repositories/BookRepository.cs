using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly MinhaBibliotecaDbContext _dbContext;

    public BookRepository(MinhaBibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Book> CreateAsync(Book book)
    {
        await _dbContext.Books.AddAsync(book);
        await _dbContext.SaveChangesAsync();
        return book;
    }

    public async Task<Book> DeleteAsync(Book book)
    {
        _dbContext.Books.Remove(book);
        await _dbContext.SaveChangesAsync();
        return book;
    }

    public async Task<IList<Book>> GetAllAsync()
    {
        return await _dbContext.Books.ToListAsync();
    }

    public async Task<Book?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Books.FindAsync(id);
    }

    public async Task<Book?> GetByIsbnAsync(string isbn)
    {
        return await _dbContext.Books.AsNoTracking().FirstOrDefaultAsync(b => b.ISBN == isbn);
    }

    public async Task<Book> UpdateAsync(Book book)
    {
        _dbContext.Books.Update(book);
        await _dbContext.SaveChangesAsync();
        return book;
    }
}
