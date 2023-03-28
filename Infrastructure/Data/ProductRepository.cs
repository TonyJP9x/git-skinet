using Core.Entity;
using Core.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }


        public async Task<Product> GetProductByIdAsync(int id)
        {
             var product = await _context.Products
                            .Include(p =>p.ProductType)
                            .Include(p =>p.ProductBrand)
                            .FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var products =  await _context.Products
                            .Include(p =>p.ProductType)
                            .Include(p =>p.ProductBrand)
                            .ToListAsync();
            return products;
        }
        public async Task<List<ProductBrand>> GetBrandsAsync()
        {
            var productBrands =  await _context.ProductBrand.ToListAsync();
            return productBrands;
        }

        public async Task<List<ProductType>> GetTypesAsync()
        {
            var productTypes = await _context.ProductType.ToListAsync();
            return productTypes;
        }

   
    }
}