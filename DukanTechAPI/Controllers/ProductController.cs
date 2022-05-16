using DukanTech.Services;
using DukanTech.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukanTechAPI.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : DukanTechControllerBase
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productservice)
        {
            _productservice = productservice ??
                throw new ArgumentNullException(nameof(productservice));
        }

        [HttpPut]
        [Route("SellProduct/{productId}")]
        public async Task<IActionResult> SellProduct(Guid productId)
       {
           var response = await  _productservice.SellProductAsync(productId);

           return GetActionResult(response);
       }

        [HttpPatch]
        [Route("UpdateProduct/{productId}/{status}")]
        public async Task<IActionResult> UpdateProduct(Guid productId, int status)
        {
            var response = await _productservice.UpdateProductStatus(productId, status);

            return GetActionResult(response);
        }

        [HttpGet]
        [Route("{status}/count")]
        [ProducesResponseType(typeof(SuccessResponse), 400)]
        public async Task<IActionResult> Get(int status)
        {
            var response = await _productservice.GetProductAsyn(status);

            return GetActionResult(response);
        }
    }
}
