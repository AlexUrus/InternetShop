using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class PackedOrder : Order
    {
        public Dictionary<Product, int> products { get; set; }

        public PackedOrder()
        {
            products = new Dictionary<Product, int>();
        }
        public PackedOrder(Order order)
        {
            adressForDelivery = order.adressForDelivery;
            Id = order.Id;
            products = new Dictionary<Product, int>();
        }
        public override string ToString()
        {
            return "Заказ номер " + this.Id + " по адресу " + adressForDelivery;
        }
    } 
}
