using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Infrastructure.Repositories;

public class BookCopyRepository : IBookCopyRepository
{
    private readonly MinhaBibliotecaDbContext _dbContext;

    public BookCopyRepository(MinhaBibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<BookCopy> CreateAsync(BookCopy bookCopy)
    {
        await _dbContext.BookCopies.AddAsync(bookCopy);
        await _dbContext.SaveChangesAsync();
        return bookCopy;
    }

    public async Task<BookCopy> DeleteAsync(BookCopy bookCopy)
    {
        _dbContext.BookCopies.Remove(bookCopy);
        await _dbContext.SaveChangesAsync();
        return bookCopy;
    }

    public async Task<IList<BookCopy>> GetAllAsync()
    {
        return await _dbContext.BookCopies.ToListAsync();
    }

    public async Task<BookCopy?> GetByIdAsync(Guid id)
    {
        return await _dbContext.BookCopies.FindAsync(id);
    }

    public async Task<BookCopy> UpdateAsync(BookCopy bookCopy)
    {
        _dbContext.BookCopies.Update(bookCopy);
        await _dbContext.SaveChangesAsync();
        return bookCopy;
    }
}