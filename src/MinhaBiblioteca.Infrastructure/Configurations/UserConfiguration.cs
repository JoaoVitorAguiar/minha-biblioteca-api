using Microsoft.EntityFrameworkCore;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .ValueGeneratedOnAdd();

        builder.HasMany(u => u.Books)
            .WithMany(b => b.Users)
            .UsingEntity<Loan>();

        builder.HasIndex(u => u.Email)
            .IsUnique();

    }
}
