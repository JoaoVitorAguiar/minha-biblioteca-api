using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Infrastructure.Configurations;

public class LoanConfiguration : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id)
            .ValueGeneratedOnAdd();
    }
}
