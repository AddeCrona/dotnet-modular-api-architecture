using System.ComponentModel.DataAnnotations;

namespace Modular.Architecture.Api.Modules.Cart.Endpoints;

public class AddToCartCommand
{
    [Required]
    public string ProductNumber { get; set; } = null!;

    [Required]
    public int Quantity { get; set; }
}

