using System;

namespace ACM.BL
{
   public class Order
    {
        public Order() { }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

    }
}
