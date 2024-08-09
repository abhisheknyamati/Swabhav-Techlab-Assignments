using System;
using System.Collections.Generic;
using ShoppingCart.Model;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        { 

            Product product1 = new Product(1, "Laptop", 155000.00, 10); 
            Product product2 = new Product(2, "Smartphone", 60000, 15); 

            LineItem lineItem1 = new LineItem(1, 2, product1); 
            LineItem lineItem2 = new LineItem(2, 3, product2); 

            Order order1 = new Order(1, DateTime.Now, new List<LineItem> { lineItem1, lineItem2 });

            Order order2 = new Order(2, DateTime.Now, new List<LineItem> { lineItem1, lineItem2 });

            Customer abhishekNyamati = new Customer(1, "Abhishek Nyamati", new List<Order> { order1, order2 });
            //--->

            Order order3 = new Order(1, DateTime.Now, new List<LineItem> { lineItem1, lineItem2 });

            Order order4 = new Order(2, DateTime.Now, new List<LineItem> { lineItem1, lineItem2 });

            Customer sangale = new Customer(2, "Sangale", new List<Order> { order1, order2 });


            PrintDetails(abhishekNyamati);

        }

        static void PrintDetails(Customer abhishekNyamati)
        {
            //foreach(Customer customer in customer)
            Console.WriteLine($"Customer ID : {abhishekNyamati.getId}");
            Console.WriteLine($"Customer Name : {abhishekNyamati.getName}");
            Console.WriteLine($"Order Count : {abhishekNyamati.getOrders.Count}");

            foreach (Order order in abhishekNyamati.getOrders)
            {
                Console.WriteLine($"\nOrder ID: {order.getID}");
                Console.WriteLine($"Order Date: {order.getDateTime}");


                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"| {"LineItemID",-10} | {"ProductID",-10} | {"ProductName",-20} | {"Quantity",-10} | {"UnitPrice",-10} | {"Discount%",-10} | {"UnitCostAfterDiscount",-22} | {"TotalLineItemCost",-20} |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");


                foreach (LineItem lineItem in order.getLineItems)
                {
                    string productName = lineItem.getProduct.getName;
                    double unitCostAfterDiscount = lineItem.getProduct.CalculateDisscountedPrice();

                    string totalLineItemCost = $"{unitCostAfterDiscount * lineItem.getQuantity:F2}";

                    Console.WriteLine($"| {lineItem.getId,-10} | {lineItem.getProduct.getId,-10} | {productName,-20} | {lineItem.getQuantity,-10} | {lineItem.getProduct.getPrice,-10:F2} | {lineItem.getProduct.getDiscountedPercentage,-10} | {unitCostAfterDiscount,-22} | {totalLineItemCost,-20} |");

                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"| Total Order Price: {order.CalculateOrderPrices(),-114} |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
