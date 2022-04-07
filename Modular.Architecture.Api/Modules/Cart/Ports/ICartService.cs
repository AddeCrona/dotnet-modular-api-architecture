using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Api.Modules.Cart.Ports;

public interface ICartService
{
    Task<Core.Domain.Ecommerce.Cart> GetCartByIdAsync(int id, CancellationToken cancellationToken);

    Task<CartItem> AddCartItemAsync(CartItem cartItem, CancellationToken cancellationToken);

    Task DeleteCartItemAsync(CartItem cartItem, CancellationToken cancellationToken);

    Task UpdateCartItemAsync(CartItem cartItem, CancellationToken cancellationToken);
}

