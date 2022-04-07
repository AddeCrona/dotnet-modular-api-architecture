using Modular.Architecture.Api.Modules.Cart.Contracts;

namespace Modular.Architecture.Api.Modules.Cart.Endpoints;

public class GetCartResult
{
    public CartModel Cart { get; set; } = null!;
}

