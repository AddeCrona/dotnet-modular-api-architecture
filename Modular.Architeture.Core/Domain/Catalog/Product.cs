namespace Modular.Architecture.Core.Domain.Catalog;

public class Product : BaseEntity
{
    public string ProductNumber { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

