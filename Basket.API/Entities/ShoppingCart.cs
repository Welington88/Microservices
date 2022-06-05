using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart {
        public string UserName { get; set; }
            public List<ShoppingCartltem> Items { get; set; } = new List<ShoppingCartltem>();
            public ShoppingCart(){}
            public ShoppingCart(string userName)
            {
                UserName = userName;
            }
            
            public decimal Totalprice { 
                get {
                    decimal totalprice = 0;
                    foreach (var item in Items)
                    {
                        totalprice += item.Price * item.Quantity;
                    }
                    return totalprice;
                }
            }
    }
}