using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Catalog
    {
        public Dictionary<string, List<Product>> products;

        private List<Product> clothes;
        private List<Product> cosmetics;
        private List<Product> technic;

        public Catalog()
        {
            clothes = new List<Product>()
            {
                { new Product("Джинсы", 1700) },
                { new Product("Кофта", 1600) },
                { new Product("Майка", 1000) }
            };
            cosmetics = new List<Product>()
            {
                { new Product("Шампунь", 300) },
                { new Product("Крем для лица", 200) },
                { new Product("Скраб", 1000) }
            };
            technic = new List<Product>()
            {
                { new Product("Пылесос", 3500) },
                { new Product("Телефон", 7000) },
                { new Product("Утюг", 2400 ) }
            };

            products = new Dictionary<string , List<Product>>()
            {
                {"Одежда", clothes},
                {"Косметика", cosmetics },
                {"Техника", technic }
            };
        }

        public void ViewCatalog()
        {
            Console.WriteLine("Выберите раздел каталога(укажите цифру)\n" +
                "1. Одежда\n" +
                "2. Косметика\n" +
                "3. Техника\n"+
                "4. Выйти из каталога");
            while (true)
            {
                int choice = 0;
                
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                      
                }
 
                switch (choice)
                {
                    case 1:
                        {
                            foreach (Product product in clothes)
                            {
                                Console.WriteLine(product);
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (Product product in cosmetics)
                            {
                                Console.WriteLine(product);
                            }
                            break ;
                        }
                    case 3:
                        {
                            foreach (Product product in technic)
                            {
                                Console.WriteLine(product);
                            }
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Неправильно указан номер раздела, укажите корректный номер");
                            break;
                        }
                }
            }
           
        }
        
    }
}
