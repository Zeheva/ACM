using System;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
                
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }


        public Order Retrieve(int orderId)
        {
            return  new Order();
        }

        public bool Save()
        {
            return true;
        }


    }
}
