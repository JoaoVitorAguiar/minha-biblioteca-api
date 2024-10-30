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

    public async Task<BookCopy?> GetFirstBookCopyAvailableByIsbnOrDefaultAsync(Book book)
    {
        var bookCopies = await _dbContext.BookCopies.Where(cp => cp.BookId == book.Id).AsNoTracking().ToListAsync();
        foreach (var bookCopy in bookCopies)
        {
            var hasActiveLoan = await _dbContext
                .Loans
                .Where(l => l.BookCopyId == bookCopy.Id && l.ReturnDate == null)
                .AnyAsync();
            if (!hasActiveLoan) return bookCopy;
        }
        return null;
    }
}