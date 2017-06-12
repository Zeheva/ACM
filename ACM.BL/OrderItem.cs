﻿namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }

        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0)
            {
                isValid = false;
            }
            if (ProductId <= 0)
            {
                isValid = false;
            }
            if (PurchasePrice == null)
            {
                isValid = false;
            }
            return isValid;

        }
    }
}
