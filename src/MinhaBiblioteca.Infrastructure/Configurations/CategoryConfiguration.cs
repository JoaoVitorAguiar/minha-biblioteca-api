using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.HasMany(c => c.Books)
            .WithOne(b => b.Category)
            .HasForeignKey(b => b.CategoryId)
            .IsRequired();

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.HasData(
            new Category("Ação") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Aventura") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Romance") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Ficção Científica") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Fantasia") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Biografia") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("História") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Mistério") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Terror") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Autoajuda") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Poesia") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Drama") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Humor") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Tecnologia") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Negócios") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Saúde") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Educação") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Religião") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Filosofia") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Category("Arte") { CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
        );
    }
}
