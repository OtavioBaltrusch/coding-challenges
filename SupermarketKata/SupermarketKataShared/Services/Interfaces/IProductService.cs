using SupermarketKataShared.Models;

namespace SupermarketKataShared.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductBySKU(string Sku);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string Sku);
    }
}
