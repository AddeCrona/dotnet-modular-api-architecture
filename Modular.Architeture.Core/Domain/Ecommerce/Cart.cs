namespace Modular.Architecture.Core.Domain.Ecommerce;

public class Cart : BaseEntity
{
    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}

