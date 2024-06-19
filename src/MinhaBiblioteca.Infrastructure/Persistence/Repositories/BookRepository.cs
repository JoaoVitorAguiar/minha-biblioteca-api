using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Infrastructure.Persistence.Repositories;

public class BookRepository : IBookRepository
{
    private readonly MinhaBibliotecaDbContext _dbContext;

    public BookRepository(MinhaBibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateAsync(Book book)
    {
        await _dbContext.Books.AddAsync(book);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(Book book)
    {
        _dbContext.Books.Remove(book);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        return await _dbContext.Books.ToListAsync();
    }

    public async Task<Book> GetByIdAsync(Guid id)
    {
        return await _dbContext.Books.FirstOrDefaultAsync(book => book.Id == id);
    }

    public async Task<Book> GetByIsbnAsync(string isbn)
    {
        return await _dbContext.Books.FirstOrDefaultAsync(book => book.ISBN == isbn);
    }

    public async Task<Book> GetByNameAsync(string title)
    {
        return await _dbContext.Books.FirstOrDefaultAsync(book => book.Title == title);
    }

    public async Task Update(Book book)
    {
        _dbContext.Books.Update(book);
        await _dbContext.SaveChangesAsync();
    }
}
