using MinhaBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Core.Services;

public interface IBookService
{
    Task<BookCopy?> GetFirstBookCopyAvailableByIsbnOrDefaultAsync(Book book);
}
