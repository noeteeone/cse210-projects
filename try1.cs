using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
    // =========================================================================
    // PRODUCT CLASS
    // =========================================================================
    public class Product
    {
        public string Name { get; set; }
        public string ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, string productId, decimal price, int quantity)
        {
            Name = name;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
        }

        // Computes the total cost by multiplying unit price by quantity
        public decimal GetTotalCost()
        {
            return Price * Quantity;
        }
    }

    // =========================================================================
    // ADDRESS CLASS
    // =========================================================================
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            StreetAddress = streetAddress;
            City = city;
            StateProvince = stateProvince;
            Country = country;
        }

        // Returns true if the country is the USA (case-insensitive check)
        public bool IsInUSA()
        {
            return Country.Equals("USA", StringComparison.OrdinalIgnoreCase) || 
                   Country.Equals("United States", StringComparison.OrdinalIgnoreCase);
        }

        // Formats all address fields into a single printable block
        public string GetFullAddressString()
        {
            return $"{StreetAddress}\n{City}, {StateProvince}\n{Country}";
        }
    }

    // =========================================================================
    // CUSTOMER CLASS
    // =========================================================================
    public class Customer
    {
        public string Name { get; set; }
        public Address CustomerAddress { get; set; }

        public Customer(string name, Address address)
        {
            Name = name;
            CustomerAddress = address;
        }

        // Delegates the country check to the Address class method
        public bool LivesInUSA()
        {
            return CustomerAddress.IsInUSA();
        }
    }

    // =========================================================================
    // ORDER CLASS
    // =========================================================================
    public class Order
    {
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }

        public Order(Customer customer)
        {
            Products = new List<Product>();
            Customer = customer;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Calculates total product costs + conditional shipping cost
        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            
            foreach (var product in Products)
            {
                total += product.GetTotalCost();
            }

            decimal shippingCost = Customer.LivesInUSA() ? 5.00m : 35.00m;
            return total + shippingCost;
        }

        // Packing label: Lists name and ID for each product
        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== PACKING LABEL ===");
            foreach (var product in Products)
            {
                sb.AppendLine($"Product: {product.Name} (ID: {product.ProductId}) x{product.Quantity}");
            }
            return sb.ToString();
        }

        // Shipping label: Lists customer name and complete address format
        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== SHIPPING LABEL ===");
            sb.AppendLine(Customer.Name);
            sb.AppendLine(Customer.CustomerAddress.GetFullAddressString());
            return sb.ToString();
        }
    }

    // =========================================================================
    // MAIN EXECUTION PROGRAM
    // =========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a US Order
            Address usAddress = new Address("123 Main St", "Seattle", "WA", "USA");
            Customer usCustomer = new Customer("John Doe", usAddress);
            Order usOrder = new Order(usCustomer);
            
            usOrder.AddProduct(new Product("Wireless Mouse", "M101", 15.50m, 2));
            usOrder.AddProduct(new Product("Mechanical Keyboard", "K502", 75.00m, 1));

            // Display US Order info
            Console.WriteLine(usOrder.GetPackingLabel());
            Console.WriteLine(usOrder.GetShippingLabel());
            Console.WriteLine($"Total Cost (including $5 USA shipping): ${usOrder.CalculateTotalCost():F2}\n");
            
            Console.WriteLine(new string('-', 40) + "\n");

            // 2. Create an International Order
            Address internationalAddress = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
            Customer internationalCustomer = new Customer("Jane Smith", internationalAddress);
            Order internationalOrder = new Order(internationalCustomer);
            
            internationalOrder.AddProduct(new Product("USB-C Hub", "H303", 40.00m, 1));
            internationalOrder.AddProduct(new Product("HDMI Cable", "C202", 12.00m, 3));

            // Display International Order info
            Console.WriteLine(internationalOrder.GetPackingLabel());
            Console.WriteLine(internationalOrder.GetShippingLabel());
            Console.WriteLine($"Total Cost (including $35 International shipping): ${internationalOrder.CalculateTotalCost():F2}");
        }
    }
}
