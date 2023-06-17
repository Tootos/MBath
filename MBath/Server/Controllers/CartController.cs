﻿using MBath.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartSrvc _cartService;

        public CartController(ICartSrvc cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetCartProductsAsync(List<CartItem> cartProducts)
        {
            var result = await _cartService.GetCartProductsAsync(cartProducts);
            return Ok(result);
        }

    }
}
