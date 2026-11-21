using System;
using ProductOrderingSystem;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        //1. Create a US Order
        Address usAddress = new Address("123 Main St", "Seattle", "WA", "USA");
        Customer usCustomer = new Customer("John Doe", usAddress);
        Order usOrder = new Order(usCustomer);

        usOrder.AddProduct(new Product("Wireless Mouse", "M101", 15.50m, 2));
        usOrder.AddProduct(new Product("Mechanical Keyboard", "K502", 75.00m, 1));

        //Display US order information
        Console.WriteLine(new string('-', 70) + "\n");
        Console.WriteLine();
        Console.WriteLine(usOrder.GetPackingLabel());
        Console.WriteLine(usOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost (including $5 USA shipping): ${usOrder.calculateTotalCost():F2}\n");
        Console.WriteLine(new string('-', 70) + "\n");

        //2. Create an international order
        Address internationalAddress = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer internationalCustomer = new Customer("Jane Smith", internationalAddress);
        Order internationalOrder = new Order(internationalCustomer);

        internationalOrder.AddProduct(new Product("USB-C Hub", "H303", 40.00m, 1));
        internationalOrder.AddProduct(new Product("HDMI Cable", "C202", 12.00m, 3));

        //Display international order information
        Console.WriteLine(internationalOrder.GetPackingLabel());
        Console.WriteLine(internationalOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost (including $35 International Shipping): ${internationalOrder.calculateTotalCost():F2}");
        Console.WriteLine(new string('-', 70) + "\n");
    }
}