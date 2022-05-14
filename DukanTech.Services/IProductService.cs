using DukanTech.Shared;
using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DukanTech.Services
{
    public interface IProductService
    {
        Task<AbstractResponse> Product(int productStatus);
        Task<AbstractResponse> SellProductAsync(Guid productId, int productStatus);
        Task<AbstractResponse> UpdateProductStatus(Guid productId, int productStatus);
        //public bool GetProductById(Guid productId);
    }
}
