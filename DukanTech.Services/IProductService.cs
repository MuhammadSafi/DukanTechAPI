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
        Task<ApiResponse<int>> GetProductAsyn(int productStatus);
        Task<AbstractResponse> SellProductAsync(Guid productId);
        Task<AbstractResponse> UpdateProductStatus(Guid productId, int productStatus);
        
    }
}
