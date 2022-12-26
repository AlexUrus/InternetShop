using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Order
    {
        public int Id { get; set; }
        public string adressForDelivery { get; set; }
        public Dictionary<string, int> listProducts { get; set; }

        public Order(Dictionary<string, int> products, string adressForDelivery)
        {
            Id = products.GetHashCode();
            this.listProducts = products;
            this.adressForDelivery = adressForDelivery;
        }

        public Order()
        {

        }
    }
}
