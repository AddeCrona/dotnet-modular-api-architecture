using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Data.Config.Ecommerce;

public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(e => e.OrderNumber)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(e => e.OrderDate)
            .IsRequired();
    }
}

