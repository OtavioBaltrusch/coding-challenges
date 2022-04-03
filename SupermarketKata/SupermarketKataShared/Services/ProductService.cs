using SupermarketKataShared.Models;

namespace SupermarketKataShared.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> products;

        public ProductService()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(string Sku)
        {
            Product? product = products.FirstOrDefault(p => p.SKU == Sku);
            if (product == null) throw new ArgumentOutOfRangeException(nameof(Sku));

            products.Remove(product);
        }

        public IEnumerable<Product> GetAllProducts() =>
            products;

        public Product GetProductBySKU(string Sku)
        {
            Product? product = products.FirstOrDefault(p => p.SKU == Sku);
            if (product == null) throw new ArgumentOutOfRangeException(nameof(Sku));

            return product;
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
