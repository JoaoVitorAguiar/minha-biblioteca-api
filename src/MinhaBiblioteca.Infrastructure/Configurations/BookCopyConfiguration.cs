using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure.Configurations;

public class BookCopyConfiguration : IEntityTypeConfiguration<BookCopy>
{
    public void Configure(EntityTypeBuilder<BookCopy> builder)
    {
        builder.HasKey(bc => bc.Id);

        builder.Property(bc => bc.Id).ValueGeneratedOnAdd();

        builder.HasMany(bc => bc.Loan)
            .WithOne(l => l.BookCopy)
            .HasForeignKey(l => l.BookCopyId);
    }
}