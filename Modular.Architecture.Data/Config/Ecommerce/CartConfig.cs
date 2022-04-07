using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Data.Config.Ecommerce;

public class CartConfig : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasData(SeedData.Carts());
    }
}

