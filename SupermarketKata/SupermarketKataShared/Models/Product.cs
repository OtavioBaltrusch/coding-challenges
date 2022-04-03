namespace SupermarketKataShared.Models;

public class Product
{
    public string SKU { get; set; }
    public decimal UnitPrice { get; set; }
    public int TriggerDiscountAmount { get; set; }
    public decimal DiscountPercentage { get; set; }

    public Product(string Sku, decimal unitPrice, int triggerDiscountAmount, decimal discountPercentage)
    {
        SKU = Sku;
        UnitPrice = unitPrice;
        TriggerDiscountAmount = triggerDiscountAmount;
        DiscountPercentage = discountPercentage;
    }
}
