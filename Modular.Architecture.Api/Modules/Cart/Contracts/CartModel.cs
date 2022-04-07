namespace Modular.Architecture.Api.Modules.Cart.Contracts;

public class CartModel
{
    public int Id { get; set; }
    public List<CartItemModel> CartItems { get; set; } = new();
    
    public decimal TotalPrice => CartItems.Sum(x => x.Price);
    public int TotalQuantity => CartItems.Sum(x => x.Quantity);
}

