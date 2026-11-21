using System;
using ProductOrderingSystem;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        //1. Create a US Order
        Address usAddress = new Address("123 Main St", "Seattle", "WA", "USA");
        Customer usCustomer = new Customer("Simba Mavhunga", usAddress);
        Order usOrder = new Order(usCustomer);

        usOrder.AddProduct(new Product("Wireless Mouse", "M101", 15.50m, 4));
        usOrder.AddProduct(new Product("Mechanical Keyboard", "K502", 75.00m, 2));

        //Display US order information
        Console.WriteLine(new string('-', 60) + "\n");
        Console.WriteLine(usOrder.GetPackingLabel());
        Console.WriteLine(usOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost (including $5 USA shipping): ${usOrder.calculateTotalCost():F2}\n");
        Console.WriteLine(new string('-', 60) + "\n");

        //2. Create an international order
        Address internationalAddress = new Address("6189 Nicoz Diamond Ave", "Harare", "Mash East", "ZIMBABWE");
        Customer internationalCustomer = new Customer("Stella Chiweshe", internationalAddress);
        Order internationalOrder = new Order(internationalCustomer);

        internationalOrder.AddProduct(new Product("USB-C Hub", "H303", 40.00m, 3));
        internationalOrder.AddProduct(new Product("HDMI Cable", "C202", 12.00m, 4));

        //Display international order information
        Console.WriteLine(internationalOrder.GetPackingLabel());
        Console.WriteLine(internationalOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost (including $35 International Shipping): ${internationalOrder.calculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine(new string('-', 60) + "\n");
    }
}