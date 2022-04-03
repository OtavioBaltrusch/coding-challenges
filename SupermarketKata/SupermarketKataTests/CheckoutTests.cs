using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupermarketKataShared.Models;
using SupermarketKataShared.Services;

namespace SupermarketKataTests
{
    [TestClass]
    public class CheckoutTests
    {
        [TestMethod]
        public void SingleItemNoDiscount()
        {
            ProductService productService = new ProductService();
            CheckoutService checkoutService = new CheckoutService(productService);

            decimal expectedTotal = 10;
            string productSku = "A";

            productService.AddProduct(new Product(productSku, 10, 3, 30));
            checkoutService.Scan(productSku);

            decimal total = checkoutService.GetTotalPrice();

            Assert.AreEqual(expectedTotal, total);
        }

        [TestMethod]
        public void SingleItemDiscount()
        {
            ProductService productService = new ProductService();
            CheckoutService checkoutService = new CheckoutService(productService);

            decimal expectedTotal = 10 * 3 * 0.7M;
            string productSku = "A";

            productService.AddProduct(new Product(productSku, 10, 3, 30));
            checkoutService.Scan(productSku, 3);

            decimal total = checkoutService.GetTotalPrice();

            Assert.AreEqual(expectedTotal, total);
        }

        [TestMethod]
        public void MultipleItemsNoDiscount()
        {
            ProductService productService = new ProductService();
            CheckoutService checkoutService = new CheckoutService(productService);

            decimal expectedTotal = 25;
            string productSku1 = "A";
            string productSku2 = "B";

            productService.AddProduct(new Product(productSku1, 10, 3, 30));
            productService.AddProduct(new Product(productSku2, 15, 3, 30));
            checkoutService.Scan(productSku1);
            checkoutService.Scan(productSku2);

            decimal total = checkoutService.GetTotalPrice();

            Assert.AreEqual(expectedTotal, total);
        }

        [TestMethod]
        public void MultipleItemsDiscount()
        {
            ProductService productService = new ProductService();
            CheckoutService checkoutService = new CheckoutService(productService);

            decimal expectedTotal = (10 * 3 * 0.7M) + (15 * 5 * 0.5M);
            string productSku1 = "A";
            string productSku2 = "B";

            productService.AddProduct(new Product(productSku1, 10, 3, 30));
            productService.AddProduct(new Product(productSku2, 15, 5, 50));
            checkoutService.Scan(productSku1, 3);
            checkoutService.Scan(productSku2, 5);

            decimal total = checkoutService.GetTotalPrice();

            Assert.AreEqual(expectedTotal, total);
        }
    }
}