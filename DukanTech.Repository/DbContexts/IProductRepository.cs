using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DukanTech.Repository.DbContexts
{
    public interface IProductRepository
    {
        Task Product(int productStatus);
        Task UpdateProductStatus(Guid productId);
        Task SellProduct(Guid productId);
        Task<bool> ExistsAsync(Guid id);
    }
}
