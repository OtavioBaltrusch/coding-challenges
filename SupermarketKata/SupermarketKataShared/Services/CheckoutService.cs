using SupermarketKataShared.Models;

namespace SupermarketKataShared.Services
{
    public class CheckoutService : ICheckoutService
    {
        private readonly IProductService productService;
        private readonly List<CheckoutProduct> basket;

        public CheckoutService(IProductService productService)
        {
            this.productService = productService;
            this.basket = new List<CheckoutProduct>();
        }

        public decimal GetTotalPrice() =>
            basket.Sum(p => GetTotalPriceForCheckoutProduct(p));

        public void Scan(string sku, int quantity = 1)
        {
            Product product = productService.GetProductBySKU(sku);

            basket.Add(new CheckoutProduct(product, quantity));
        }

        private decimal GetTotalPriceForCheckoutProduct(CheckoutProduct checkoutProduct) =>
            checkoutProduct.Quantity >= checkoutProduct.Product.TriggerDiscountAmount ?
            checkoutProduct.Product.UnitPrice * checkoutProduct.Quantity * (1 - (checkoutProduct.Product.DiscountPercentage / 100)) :
            checkoutProduct.Product.UnitPrice * checkoutProduct.Quantity;
    }
}
