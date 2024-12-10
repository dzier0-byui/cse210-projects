using System;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", customerAddress1);
        Address customerAddress2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", customerAddress2);

        Order order1 = new Order(customer1);
        Product product1 = new Product("Laptop", "P001", 800, 1);
        order1.AddProduct(product1);
        Product product2 = new Product("Mouse", "P002", 20, 2);
        order1.AddProduct(product2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        Product product4 = new Product("Monitor", "P004", 200, 1);
        order2.AddProduct(product4);
        Product product5 = new Product("Desk Chair", "P005", 150, 1);
        order2.AddProduct(product5);
        Product product6 = new Product("USB Cable", "P006", 10, 3);
        order2.AddProduct(product6);

        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}