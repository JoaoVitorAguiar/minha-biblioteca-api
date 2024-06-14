using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure;

public class MinhaBibliotecaDbContext : DbContext
{
    public DbSet<User> Users { get; private set; }
    public DbSet<Book> Books { get; private set; }
    public DbSet<Loan> Loans { get; private set; }
    public MinhaBibliotecaDbContext(DbContextOptions<MinhaBibliotecaDbContext> options) : base(options)
    {
    }
}
