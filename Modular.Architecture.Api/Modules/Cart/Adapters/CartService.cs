using Modular.Architecture.Api.Modules.Cart.Ports;
using Modular.Architecture.Core;
using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Api.Modules.Cart.Adapters;

public class CartService : ICartService
{
    private readonly IAsyncRepository<CartItem> _cartItemRepository;
    private readonly IAsyncRepository<Core.Domain.Ecommerce.Cart> _cartRepository;

    public CartService(IAsyncRepository<CartItem> cartItemRepository,
        IAsyncRepository<Core.Domain.Ecommerce.Cart> cartRepository)
    {
        _cartItemRepository = cartItemRepository;
        _cartRepository = cartRepository;
    }

    public async Task<CartItem> AddCartItemAsync(CartItem cartItem, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(cartItem, nameof(cartItem));

        return await _cartItemRepository.AddAsync(cartItem ,cancellationToken);
    }

    public async Task DeleteCartItemAsync(CartItem cartItem, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(cartItem, nameof(cartItem));
        await _cartItemRepository.DeleteAsync(cartItem ,cancellationToken);
    }

    public async Task<Core.Domain.Ecommerce.Cart> GetCartByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _cartRepository.GetByIdAsync(id, cancellationToken);
    }

    public async Task UpdateCartItemAsync(CartItem cartItem, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(cartItem, nameof(cartItem));
        await _cartItemRepository.UpdateAsync(cartItem, cancellationToken);
    }
}

