namespace Modular.Architecture.Api.Modules.Cart.Contracts;

public class CartItemModel
{
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public string ProductNumber { get; set; } = null!;
    public string ProductName { get; set; } = null!;
    public decimal Price { get; set; }
}

