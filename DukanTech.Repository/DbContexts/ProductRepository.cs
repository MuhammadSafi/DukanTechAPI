using DukanTech.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukanTech.Repository.DbContexts
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        
        public async Task<bool> ExistsAsync(Guid id) => await _context.Products.AnyAsync(e => e.Id == id);

        public async Task<int> Product(int productStatus)
        {
            var total = await _context.Products.Where(a=>a.Status == productStatus).CountAsync();
            return total;
        }

        public async Task SellProduct(Guid productId)
        {
            var result = await _context.Products.SingleOrDefaultAsync(a => a.Id == productId);
            result.Status = (int)ProductStatus.Sold;
            await _context.SaveChangesAsync();
        }

        public void UpdateProductStatus(Guid productId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProductStatus(Guid productId, int status)
        {
            var result = await _context.Products.SingleOrDefaultAsync(a => a.Id == productId);
            result.Status = status;
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
