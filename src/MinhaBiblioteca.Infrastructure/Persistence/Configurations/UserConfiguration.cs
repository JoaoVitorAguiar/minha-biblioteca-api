using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder
            .HasMany(u => u.Loans)
            .WithOne(l => l.User)
            .HasForeignKey(u => u.UserId);

        builder.HasIndex(u => u.Email).IsUnique();

        builder.Property(u => u.Role)
                   .HasConversion<int>();

    }
}
