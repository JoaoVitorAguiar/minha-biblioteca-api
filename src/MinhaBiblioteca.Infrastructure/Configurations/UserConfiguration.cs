using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .ValueGeneratedOnAdd();

        builder.HasMany(u => u.Loans)
            .WithOne(l => l.User)
            .HasForeignKey(l => l.UserId);

        builder.HasIndex(u => u.Email)
            .IsUnique();
    }
}
