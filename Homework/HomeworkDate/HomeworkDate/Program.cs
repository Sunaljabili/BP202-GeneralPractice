using HomeworkDate.Models;
using System;

namespace HomeworkDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.CreatedAt = new DateTime(2020,11,20);
            order.ProductCount = 3;
            order.TotalAmount = 40;

            Order order2 = new Order();
            order2.CreatedAt = new  DateTime(2021,12,25);
            order2.ProductCount = 3;
            order2.TotalAmount = 25;

            Order order3 = new Order();
            order3.CreatedAt = new DateTime(2020,06,14);
            order3.ProductCount = 3;
            order3.TotalAmount = 25;

            Shop shop = new Shop();
            shop.AddOrder(order);
            shop.AddOrder(order2);
            shop.AddOrder(order3);


            Console.WriteLine("====GetOrdersAvg====");
            Console.WriteLine(shop.GetOrdersAvg()); 

            Console.WriteLine("====GetOrdersAvg DateTime====");
            DateTime date = new DateTime(2000/12/12);
            Console.WriteLine(shop.GetOrdersAvg(date));


            Console.WriteLine("Remove Method");
            shop.RemoveOrderByNo(3);


            foreach (var item in shop.orders)
            {
                Console.WriteLine(item.TotalAmount);
            }

            Console.WriteLine("===Filter Price===");
            
            foreach (var item in shop.FilterOrderByPrice(30, 50))
            {
                Console.WriteLine(item.TotalAmount);
            }
        }
    }
}
