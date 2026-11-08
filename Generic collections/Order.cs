using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collections
{
    internal class Order
    {

        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {_orderId}, Table Number: {_tableNumber}");
            foreach (var item in _orderItems)
            {
                Console.WriteLine($"- {item.Name} : {item.Price} kr");
            }
        }


    }
}
