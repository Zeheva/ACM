using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repositories
{
   public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            var order = new Order(1);

            if (order.OrderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;


        }

        public bool Save()
        {
            return true;
        }
    }
}
