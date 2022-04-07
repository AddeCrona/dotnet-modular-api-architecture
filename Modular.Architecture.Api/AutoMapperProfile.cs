using AutoMapper;
using Modular.Architecture.Api.Modules.Cart.Contracts;
using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Api;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Cart, CartModel>()
            .ForMember(x => x.CartItems, m => m.MapFrom<CartItemsResolver>());
    }

    private class CartItemsResolver : IValueResolver<Cart, CartModel, List<CartItemModel>>
    {
        public List<CartItemModel> Resolve(Cart source, CartModel destination, List<CartItemModel> destMember, ResolutionContext context)
        {
            return source.CartItems.ToList().Select(x => new CartItemModel
            {
                ProductId = x.ProductId,
                ProductName = x.Product.ProductName,
                ProductNumber = x.Product.ProductNumber,
                Quantity = x.Quantity,
                Price = x.Product.Price
            }).ToList();
        }
    }
}
