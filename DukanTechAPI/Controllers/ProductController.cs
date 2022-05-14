using DukanTech.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukanTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : DukanTechControllerBase
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productservice)
        {
            _productservice = productservice ??
                throw new ArgumentNullException(nameof(productservice));
        }

        [HttpPatch("{productId}")]
        public async Task<IActionResult> SellProduct(Guid productId, int status)
        {
            var response = await  _productservice.SellProductAsync(productId, status);

            return GetActionResult(response);
        }

        [HttpPatch("{productId}")]
        public async Task<IActionResult> UpdateProduct(Guid productId, int status)
        {
            var response = await _productservice.UpdateProductStatus(productId, status);

            return GetActionResult(response);
        }

        [HttpGet("{status}")]
        public async Task<IActionResult> UpdateProduct(int status)
        {
            var response = await _productservice.Product(status);

            return GetActionResult(response);
        }
    }
}
