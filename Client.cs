using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Client : Human
    {
        
        private string number;
        private string adress;
        private ShopCart cart;

        public Client(string name,string surname, string number, string adress)
        {
            this.surname = surname;
            this.name = name;
            this.number = number;
            this.adress = adress;
            cart = new ShopCart(adress);
        }
        public override void Indroduce()
        {
            Console.WriteLine("Я клиент " + name + " " + surname);
        }

        public void ViewCatalog(Catalog catalog)
        {
            catalog.ViewCatalog();
        }
        
        public Order? MakeOrder()
        {
           return cart.CreateOrder();
        }
        
        public void AddProductInCart()
        {
            while (true)
            {
                Console.WriteLine("Напишите название продукта, который хотите приобрести:\n"+
                    "Чтобы прекратить покупку нажните цифру 0");
                string nameProduct = Console.ReadLine();
                if(nameProduct == "0")
                {
                    break;
                }
                Console.WriteLine("Укажите количество: ");
                int count = int.Parse(Console.ReadLine());
                if (cart.AddProduct(nameProduct, count))
                {
                    Console.WriteLine(nameProduct + " в количестве " + count + " штук добавлен в корзину"); 
                }
            }
        }

        public void RemoveProductInCart()
        { 
            while (true)
            {
                Console.WriteLine("Напишите название продукта, который хотите удалить из корзины ");
                string nameProduct = Console.ReadLine();
                if (cart.RemoveProduct(nameProduct))
                {
                    Console.WriteLine(nameProduct + " удален из корзины");
                    break;
                }
            }
        }

        
    }
}
