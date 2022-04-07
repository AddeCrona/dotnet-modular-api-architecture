namespace Modular.Architecture.Core.Domain.Ecommerce;

public class Order : BaseEntity
{
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}

