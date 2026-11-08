using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collections
{
    internal class Restaurant
    {


        public List<MenuItem> MENYITEM = new List<MenuItem>();
        public Queue<Order> Bestälingar = new Queue<Order>();

        public void AddtoMenu(MenuItem menuItem)
        {


            MENYITEM.Add(menuItem);
            Console.WriteLine($"Bestling laddes till i Menyn: {menuItem.Name}");

        }

        public void ShowMenu()
        {

            Console.WriteLine("------ Menyn ------");
            foreach (MenuItem menuItem in MENYITEM)
            {


                Console.WriteLine($"{menuItem.Id} : {menuItem.Name} : {menuItem.Price} kr");


            }


        }

        public void CreateOrder(Order order)
        {

            Bestälingar.Enqueue(order);


        }


        public void HandleOrder()
        {

            Bestälingar.Dequeue();


        }


        public void ShowOrders()
        {
            Console.WriteLine("------Bestälingar------");
            foreach (Order Besting in Bestälingar)
            {


                Besting.DisplayOrder();


            }

        }

        public void ShowNextOrder()
        {
            if (Bestälingar.Count > 0)
            {
                Order nextOrder = Bestälingar.Peek();
                Console.WriteLine("------Nästa Bestäling------");
                nextOrder.DisplayOrder();
            }
            else
            {
                Console.WriteLine("Finns inga bestälingar.");
            }
        }

        public void ShowOrderCount()
        {
            Console.WriteLine($"Alla bestälingar i kön: {Bestälingar.Count}");
        }


        public void NotInProgrameResturant()
        {

            Restaurant Food = new Restaurant();

            Food.AddtoMenu(new MenuItem(1, "Hamburgare", 85m));
            Food.AddtoMenu(new MenuItem(2, "Sushi", 95m));
            Food.AddtoMenu(new MenuItem(3, "Pizza", 95m));
            Food.AddtoMenu(new MenuItem(4, "Kebab", 85m));
            Food.AddtoMenu(new MenuItem(5, "Kebab Pizza", 115m));
            Food.AddtoMenu(new MenuItem(6, "SushiBurgare", 115m));


            Food.ShowMenu();

            Food.CreateOrder(new Order(new List<MenuItem> { new MenuItem(1, "Hamburgare", 85m) }, 1));
            Food.CreateOrder(new Order(new List<MenuItem> { new MenuItem(2, "Sushi", 95m) }, 2));
            Food.CreateOrder(new Order(new List<MenuItem> { new MenuItem(3, "Pizza", 95m) }, 3));

            Food.ShowOrders();

            Food.ShowOrderCount();

            Food.ShowNextOrder();

            Food.HandleOrder();

            Food.ShowOrderCount();

            Food.CreateOrder(new Order(new List<MenuItem> { new MenuItem(6, "SushiBurgare", 115m) }, 4));

            Food.ShowOrderCount();

            Food.HandleOrder();

            Food.HandleOrder();

            Food.ShowOrderCount();

            Food.ShowNextOrder();

            Food.HandleOrder();

            Food.ShowOrders();

            Console.ReadKey();

        }
    }
}
