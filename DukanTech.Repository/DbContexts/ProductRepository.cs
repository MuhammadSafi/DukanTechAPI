using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DukanTech.Repository.DbContexts
{
    public class ProductRepository : IProductRepository
    {
        public Task<bool> ExistsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Product(int productStatus)
        {
            throw new NotImplementedException();
        }

        public Task  SellProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductStatus(Guid productId)
        {
            throw new NotImplementedException();
        }

        Task IProductRepository.UpdateProductStatus(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
