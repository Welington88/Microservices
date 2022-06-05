namespace Basket.API.Entities
{
    public class ShoppingCartltem
    {
        public string? Productld { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}