using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure;

public class MinhaBibliotecaDbContext: DbContext
{
    public MinhaBibliotecaDbContext(DbContextOptions<MinhaBibliotecaDbContext> options): base(options)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Loan> Loans { get; set; }
    public DbSet<Category> Categories { get; set; }


}
