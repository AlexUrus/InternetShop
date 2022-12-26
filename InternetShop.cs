using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class InternetShop
    {

        private string name;
        private string url;
        private Catalog catalog = new Catalog();
        

        public InternetShop(string name, string url)
        {
            this.name = name;
            this.url = url; 
        }

        public Client CreateClient(string nameClient,string surname,string number,string adress)
        {
            return new Client(nameClient,surname,number,adress);
        }

        public Catalog GetCatalog()
        {
           return catalog;
        }

        static void Main(string[] args)
        {
            InternetShop internetShop = new InternetShop("Shop54","http://Shop54");
            OrderCollector orderCollector = new OrderCollector("Иванов Иван Иванович");
            Delivery delivery = new Delivery();
            Client client = internetShop.CreateClient("Глеб","Горожанин", "345-234", "Улица Пушкина Дом Колотушкина");
            client.ViewCatalog(internetShop.GetCatalog());
            client.AddProductInCart();
            Order order = client.MakeOrder();
            PackedOrder packedOrder = orderCollector.CollectOrder(order);
            delivery.SendForDelivery(packedOrder);
            
        }
    }
}
