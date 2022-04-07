using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Modular.Architecture.Api.Modules.Cart.Contracts;
using Modular.Architecture.Api.Modules.Cart.Ports;
using Swashbuckle.AspNetCore.Annotations;

namespace Modular.Architecture.Api.Modules.Cart.Endpoints;

public class Get : EndpointBaseAsync
    .WithoutRequest
    .WithActionResult<GetCartResult>
{

    private readonly ICartService _cartService;
    private readonly IMapper _mapper;

    public Get(ICartService cartService,
        IMapper mapper)
    {
        _cartService = cartService;
        _mapper = mapper;
    }


    /// <summary>
    /// Get cart
    /// </summary>
    [HttpGet("api/[namespace]/{id}", Name = "[namespace]_[controller]")]
    [SwaggerOperation(
        Summary = "Get cart",
        OperationId = "Cart.Get",
        Tags = new[] { "CartEndpoint" })
    ]
    public override async Task<ActionResult<GetCartResult>> HandleAsync(CancellationToken cancellationToken = default)
    {
        var cart = await _cartService.GetCartByIdAsync(1, cancellationToken);

        if (cart is null) return NotFound();

        var cartModel = _mapper.Map<CartModel>(cart);

        return Ok(new GetCartResult { Cart = cartModel });
    }
}

