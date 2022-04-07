using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modular.Architecture.Core.Domain.Catalog;

namespace Modular.Architecture.Data.Config.Catalog;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(e => e.ProductName)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(e => e.ProductNumber)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(e => e.Price)
            .HasPrecision(14,2)
            .IsRequired();

        builder.HasData(SeedData.Products());
    }
}

