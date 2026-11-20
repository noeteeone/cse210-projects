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
        private string _name;
        private string _productId;
        private decimal _price;
        private int _quantity;

        public Product(string name, string productId, decimal price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        // Getters and Setters
        public string GetName() => _name;
        public void SetName(string name) => _name = name;

        public string GetProductId() => _productId;
        public void SetProductId(string productId) => _productId = productId;

        public decimal GetPrice() => _price;
        public void SetPrice(decimal price) => _price = price;

        public int GetQuantity() => _quantity;
        public void SetQuantity(int quantity) => _quantity = quantity;

        // Computes the total cost by multiplying unit price by quantity
        public decimal GetTotalCost()
        {
            return _price * _quantity;
        }
    }

    // =========================================================================
    // ADDRESS CLASS
    // =========================================================================
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        // Getters and Setters
        public string GetStreetAddress() => _streetAddress;
        public void SetStreetAddress(string streetAddress) => _streetAddress = streetAddress;

        public string GetCity() => _city;
        public void SetCity(string city) => _city = city;

        public string GetStateProvince() => _stateProvince;
        public void SetStateProvince(string stateProvince) => _stateProvince = stateProvince;

        public string GetCountry() => _country;
        public void SetCountry(string country) => _country = country;

        // Returns true if the country is the USA (case-insensitive check)
        public bool IsInUSA()
        {
            return _country.Equals("USA", StringComparison.OrdinalIgnoreCase) || 
                   _country.Equals("United States", StringComparison.OrdinalIgnoreCase);
        }

        // Formats all address fields into a single printable block
        public string GetFullAddressString()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }

    // =========================================================================
    // CUSTOMER CLASS
    // =========================================================================
    public class Customer
    {
        private string _name;
        private Address _customerAddress;

        public Customer(string name, Address address)
        {
            _name = name;
            _customerAddress = address;
        }

        // Getters and Setters
        public string GetName() => _name;
        public void SetName(string name) => _name = name;

        public Address GetCustomerAddress() => _customerAddress;
        public void SetCustomerAddress(Address address) => _customerAddress = address;

        // Delegates the country check to the Address class method
        public bool LivesInUSA()
        {
            return _customerAddress.IsInUSA();
        }
    }

    // =========================================================================
    // ORDER CLASS
    // =========================================================================
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        // Getters and Setters
        public List<Product> GetProducts() => _products;
        public void SetProducts(List<Product> products) => _products = products;

        public Customer GetCustomer() => _customer;
        public void SetCustomer(Customer customer) => _customer = customer;

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Calculates total product costs + conditional shipping cost
        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            
            foreach (var product in _products)
            {
                total += product.GetTotalCost();
            }

            decimal shippingCost = _customer.LivesInUSA() ? 5.00m : 35.00m;
            return total + shippingCost;
        }

        // Packing label: Lists name and ID for each product
        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== PACKING LABEL ===");
            foreach (var product in _products)
            {
                sb.AppendLine($"Product: {product.GetName()} (ID: {product.GetProductId()}) x{product.GetQuantity()}");
            }
            return sb.ToString();
        }

        // Shipping label: Lists customer name and complete address format
        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== SHIPPING LABEL ===");
            sb.AppendLine(_customer.GetName());
            sb.AppendLine(_customer.GetCustomerAddress().GetFullAddressString());
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
