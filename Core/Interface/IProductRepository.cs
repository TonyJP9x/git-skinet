using Core.Entity;

namespace Core.Interface
{
    public interface IProductRepository
    {
         Task<List<Product>> GetProductsAsync();
         Task<Product> GetProductByIdAsync(int id);
         Task<List<ProductBrand>> GetBrandsAsync();
         Task<List<ProductType>> GetTypesAsync();

        
    }
}