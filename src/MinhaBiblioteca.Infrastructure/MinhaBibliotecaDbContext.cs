using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;
using System.Reflection;

namespace MinhaBiblioteca.Infrastructure;

public class MinhaBibliotecaDbContext : DbContext
{
    public DbSet<User> Users { get; private set; }
    public DbSet<Book> Books { get; private set; }
    public DbSet<Loan> Loans { get; private set; }
    public MinhaBibliotecaDbContext(DbContextOptions<MinhaBibliotecaDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Assembly assemblyWithConfigurations = GetType().Assembly; //get whatever assembly you want
        modelBuilder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
    }
}
