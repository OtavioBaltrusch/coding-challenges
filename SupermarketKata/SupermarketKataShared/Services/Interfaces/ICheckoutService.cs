namespace SupermarketKataShared.Services
{
    public interface ICheckoutService
    {
        void Scan(string sku, int quantity = 1);
        decimal GetTotalPrice();
    }
}
