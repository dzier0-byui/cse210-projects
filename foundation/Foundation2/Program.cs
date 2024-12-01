using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Alice Johnson", new Address("123 Elm St", "Springfield", "IL", "USA"));
        Customer customer2 = new Customer("Bob Smith", new Address("456 Oak Ave", "Toronto", "ON", "Canada"));

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P002", 20, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 50, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P004", 200, 1));
        order2.AddProduct(new Product("Desk Chair", "P005", 150, 1));
        order2.AddProduct(new Product("USB Cable", "P006", 10, 3));

        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}