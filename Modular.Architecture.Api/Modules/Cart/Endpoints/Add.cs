using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Modular.Architecture.Api.Modules.Cart.Ports;
using Swashbuckle.AspNetCore.Annotations;

namespace Modular.Architecture.Api.Modules.Cart.Endpoints;

public class Add : EndpointBaseAsync
    .WithRequest<AddToCartCommand>
    .WithActionResult<AddToCartResult>
{
    private readonly ICartService _cartService;

    public Add(ICartService cartService)
    {
        _cartService = cartService;
    }


    /// <summary>
    /// Adds product to cart
    /// </summary>
    [HttpPost("api/[namespace]")]
    [SwaggerOperation(
        Summary = "Add product to cart",
        OperationId = "Cart.Add",
        Tags = new[] { "CartEndpoint" })
    ]
    public override async Task<ActionResult<AddToCartResult>> HandleAsync([FromBody]AddToCartCommand request, CancellationToken cancellationToken = default)
    {
        return Ok();
    }
}

