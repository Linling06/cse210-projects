using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "525 South Center Street",
            "Rexburg",
            "ID",
            "USA"
        );

        Customer customer1 = new Customer(
            "Emily Johnson",
            address1
        );

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop Stand", "LS1001", 24.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "WM2002", 18.50, 2));
        order1.AddProduct(new Product("Notebook", "NB3003", 3.25, 5));

        Address address2 = new Address(
            "88 Nanjing Road",
            "Shanghai",
            "Shanghai",
            "China"
        );

        Customer customer2 = new Customer(
            "Mei Chen",
            address2
        );

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Water Bottle", "WB4004", 12.75, 2));
        order2.AddProduct(new Product("Desk Lamp", "DL5005", 29.99, 1));

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
