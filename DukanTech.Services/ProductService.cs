using DukanTech.Repository.DbContexts;
using DukanTech.Shared;
using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DukanTech.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
           _productRepository = productRepository;
        }

        //public bool GetProductById(Guid productId)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<AbstractResponse> Product(int productStatus)
        {
            try
            {
              
                await _productRepository.Product(productStatus);
                return new PassedResponse(StatusCode.Success);
            }
            catch (Exception ex)
            {
                return new ErrorResponse(StatusCode.UnhandledException, ex);
            }
        }

        public async Task<AbstractResponse> SellProductAsync(Guid productId, int productStatus)
        {
            try
            {
                if (!await _productRepository.ExistsAsync(productId))
                {
                    return new ErrorResponse(StatusCode.ProductNotFound);
                }

                await _productRepository.SellProduct(productId);
                return new PassedResponse(StatusCode.Updated);
            }
            catch (Exception ex)
            {
                return new ErrorResponse(StatusCode.UnhandledException, ex);
            }
        }
        public async Task<AbstractResponse> UpdateProductStatus(Guid productId, int productStatus)
        {
            try
            {
                if (!await _productRepository.ExistsAsync(productId))
                {
                    return new ErrorResponse(StatusCode.ProductNotFound);
                }

                await _productRepository.UpdateProductStatus(productId);
                return new PassedResponse(StatusCode.Updated);
            }
            catch (Exception ex)
            {
                return new ErrorResponse(StatusCode.UnhandledException, ex);
            }
        }
    }
}
