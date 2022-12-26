using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class OrderCollector : Human
    {


        public Catalog catalog;

        public OrderCollector(string name)
        {
            this.name = name;
            catalog = new Catalog();
        }
        public override void Indroduce()
        {
            Console.WriteLine("Я сборщик заказов " + name);
        }

        private Product FindProduct(string nameProduct)
        {
            foreach(var list in catalog.products.Values)
            {
                foreach(Product item in list)
                {
                    if(item.name == nameProduct)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public PackedOrder CollectOrder(Order order)
        {
            PackedOrder packedOrder = new PackedOrder(order);
            foreach (var nameProd in order.listProducts.Keys)
            {
                Product product = FindProduct(nameProd);
                packedOrder.products.Add(product,order.listProducts[nameProd]);
            }
            return packedOrder;
        }

        
    }
}
