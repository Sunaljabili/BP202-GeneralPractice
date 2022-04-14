using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDate.Models
{
   public  class Shop
    {
        public List<Order> orders = new List<Order>();


        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public double GetOrdersAvg()
        {
            double sum = 0;

            foreach (var item in orders)
            {
                sum += item.TotalAmount;
            }
            return sum / orders.Count;
        }

        public double GetOrdersAvg(DateTime datetime)
        {
            double sum = 0;
            int count = 0;
            foreach (var item in orders)
            {

                if (item.CreatedAt> datetime)
                {
                    sum += item.TotalAmount;
                    count++;
                }
            }
            return sum / count;
        }


        public void RemoveOrderByNo(int? no)
        {
            if (no ==null)
            {
                throw new Exception("Null ola bilmez");
            }
            orders.Remove(orders.Find(x => x.No == no));
        }

        public List<Order> FilterOrderByPrice(double minPrice,double maxPrice)
        {
            return orders.FindAll(x => x.TotalAmount > minPrice && x.TotalAmount < maxPrice);
          
        }

    }
}
