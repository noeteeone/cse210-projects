using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }
        //Getters and Setters
        public List<Product> GetProducts() => _products;
        public void SetProducts(List<Product> products) => _products = products;

        public Customer GetCustomer() => _customer;
        public void SetCustomer(Customer customer) => _customer = customer;

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        //calculate total product costs + conditional shipping cost
        public decimal calculateTotalCost()
        {
            decimal total = 0;

            foreach (var product in _products)
            {
                total += product.GetTotalCost();
            }
            decimal shippingCost = _customer.LivesInUSA() ? 5.00m : 35.00m;
            return total + shippingCost;
        }
        //Packing label: Lists name and ID for each product
        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====== PACKING LABEL ==========");
            foreach (var product in _products)
            {
                sb.AppendLine($"Product: {product.GetName()} (ID: {product.GetProductId()}) X {product.GetQuantity()}");
            }
            return sb.ToString();
        }
        //Shipping Label: List Customer name and complete address format
        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====== SHIPPING LABEL ==========");
            sb.AppendLine(_customer.GetName());
            sb.AppendLine(_customer.GetCustomerAddress().GetFullAddressString());

            return sb.ToString();
        }
    }
}