using Modular.Architecture.Core.Domain.Catalog;
using Modular.Architecture.Core.Domain.Ecommerce;

namespace Modular.Architecture.Data;

public static class SeedData
{
    public static List<Product> Products()
    {
        var products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    ProductName ="Schampoo deluxe",
                    ProductNumber = "T-1234-ab23",
                    Price = 120.50m
                },
                new Product
                {
                    Id = 2,
                    ProductName ="Soap deluxe",
                    ProductNumber = "T-1654-cf54",
                    Price = 119.50m
                },
                new Product
                {
                    Id = 3,
                    ProductName ="Comb",
                    ProductNumber = "T-9865-hk94",
                    Price = 59.99m
                },
                new Product
                {
                    Id = 4,
                    ProductName ="Toilet paper",
                    ProductNumber = "T-4567-tf34",
                    Price = 99.50m
                },
                new Product
                {
                    Id = 5,
                    ProductName ="Hair spray",
                    ProductNumber = "T-1276-ww33",
                    Price = 29.99m
                },
            };

        return products;
    }

    public static List<Cart> Carts()
    {
        var carts = new List<Cart>()
            {
                new Cart
                {
                    Id = 1
                },
                new Cart
                {
                    Id = 2
                }
            };

        return carts;
    }

    public static List<CartItem> CartItems()
    {
        var cartItems = new List<CartItem>()
            {
                new CartItem
                {
                    Id = 1,
                    CartId = 1,
                    ProductId = 2
                },
                new CartItem
                {
                    Id = 2,
                    CartId = 1,
                    ProductId = 1
                },
                new CartItem
                {
                    Id = 3,
                    CartId = 1,
                    ProductId = 4
                },
                new CartItem
                {
                    Id = 4,
                    CartId = 2,
                    ProductId = 3
                },
                new CartItem
                {
                    Id = 5,
                    CartId = 2,
                    ProductId = 5
                },
            };

        return cartItems;
    }
}

