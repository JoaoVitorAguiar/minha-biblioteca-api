using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Exceptions;
using MinhaBiblioteca.Core.Services;

namespace MinhaBiblioteca.Infrastructure.Services;

public class BookService : IBookService
{
    private readonly MinhaBibliotecaDbContext _dbContext;

    public BookService(MinhaBibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Book?> GetFirstBookAvailableByIsbnOrDefaultAsync(string isbn)
    {
        var books = await _dbContext.Books
                .Where(b => b.ISBN == isbn)
                .ToListAsync();
        if (!books.Any()) { throw new NotFoundException(typeof(Book)); }

        foreach (var book in books)
        {
            var hasActiveLoan = await _dbContext.Loans
                .Where(l => l.BookId == book.Id && l.ReturnDate == null)
                .AnyAsync();

            if (!hasActiveLoan)
            {
                return book;
            }
        }

        return null;
    }
}
