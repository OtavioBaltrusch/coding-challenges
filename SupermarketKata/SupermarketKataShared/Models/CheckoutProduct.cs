namespace SupermarketKataShared.Models
{
    public class CheckoutProduct
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CheckoutProduct(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
