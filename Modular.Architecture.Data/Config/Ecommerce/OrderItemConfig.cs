using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Data.Config.Ecommerce;

public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.Property(e => e.ProductNumber)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(e => e.ProductName)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(e => e.Quantity)
            .IsRequired();

        builder.Property(e => e.PaidPrice)
            .HasPrecision(14, 2)
            .IsRequired();

        builder.HasOne(e => e.Order)
            .WithMany(e => e.OrderItems)
            .HasForeignKey(e => e.OrderId)
            .IsRequired();
    }
}

