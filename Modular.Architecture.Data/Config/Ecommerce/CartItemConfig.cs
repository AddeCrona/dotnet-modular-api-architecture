using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Data.Config.Ecommerce;

public class CartItemConfig : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.HasOne(e => e.Cart)
            .WithMany(e => e.CartItems)
            .HasForeignKey(e => e.CartId);

        builder.Property(e => e.Quantity)
            .IsRequired();

        builder.HasOne(e => e.Product)
            .WithMany()
            .HasForeignKey(e => e.ProductId)
            .IsRequired();

        builder.HasData(SeedData.CartItems());
    }
}

