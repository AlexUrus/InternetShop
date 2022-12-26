using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Delivery
    {
        public string OrderStatus = "Не отправлен";
        public void SendForDelivery(PackedOrder packedOrder)
        {
            Console.WriteLine("Отправлен " + packedOrder);
            OrderStatus = "Заказ отправлен";
        }

    }
}
