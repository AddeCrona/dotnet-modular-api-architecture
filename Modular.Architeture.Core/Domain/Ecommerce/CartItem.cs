using Modular.Architecture.Core.Domain.Catalog;

namespace Modular.Architecture.Core.Domain.Ecommerce;

public class CartItem : BaseEntity
{
    public int Quantity { get; set; }
  
    public int CartId { get; set; }
    
    public virtual Cart Cart { get; set; }

    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}

