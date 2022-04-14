using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDate.Models
{
   public class Order
    {
        private static int _no;
        public int No { get; set; }
        public Order()
        {
            _no++;
            No = _no;
        }

        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
