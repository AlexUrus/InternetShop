using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopCart
    {
        private string adressForDelivery;
        private Catalog catalog;
        private int totalPrice;
        Dictionary<string, int> productsInCart = new Dictionary<string, int>();

        public ShopCart(string adressForDelivery)
        {
            this.adressForDelivery = adressForDelivery;
            catalog = new Catalog();
            totalPrice = 0;
        }
        

        private bool ExistsProduct(string nameProduct)
        {
            bool exists = false;
            foreach (List<Product> list in catalog.products.Values)
            {
                foreach (Product product in list)
                {
                    if (product.name == nameProduct)
                    {
                        exists = true;
                    }
                }
            }
            return exists;
        }

        private void CountingMoney()
        {
            foreach(var prods in productsInCart)
            {
                PlusPriceProduct(prods.Key,prods.Value);
            }
        }

        private void PlusPriceProduct(string nameProduct, int count)
        {
            foreach (List<Product> list in catalog.products.Values)
            {
                foreach (Product product in list)
                {
                    if (product.name == nameProduct)
                    {
                        totalPrice +=  product.price * count;
                    }
                }
            }
        }

        public bool AddProduct(string nameProduct,int count)
        {

            if (ExistsProduct(nameProduct))
            {
                productsInCart[nameProduct] = count;
                return true;
            }
            else
            {
                Console.WriteLine("Такого продукта нету");
                return false;
            }
            
        }
        public bool RemoveProduct(string nameProduct)
        {
            if (ExistsProduct(nameProduct))
            {
                productsInCart.Remove(nameProduct);
                return true;
            }
            else
            {
                Console.WriteLine("Такого продукта нету");
                return false;
            }
        }

        public Order? CreateOrder()
        {
            CountingMoney();
            Console.WriteLine("С вашей карты списано " + totalPrice + " рублей");
            return new Order(productsInCart,adressForDelivery);
        }
    }
}
