using Modular.Architecture.Api.Modules.Cart.Adapters;
using Modular.Architecture.Api.Modules.Cart.Ports;

namespace Modular.Architecture.Api.Modules.Cart;

public class CartModule : IModule
{
    public IServiceCollection RegisterModule(IServiceCollection services)
    {
        services.AddTransient<ICartService, CartService>();

        return services;
    }
}
