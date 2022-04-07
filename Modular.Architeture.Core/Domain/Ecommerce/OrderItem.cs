namespace Modular.Architecture.Core.Domain.Ecommerce;

public class OrderItem : BaseEntity
{
    public string ProductNumber { get; set; }
    public string ProductName { get; set; }
    public decimal PaidPrice { get; set; }
    public int Quantity { get; set; }

    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
}
