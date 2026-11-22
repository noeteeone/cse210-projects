using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
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

        //Getters and Setters
        public string GetName() => _name;
        public void SetName(string name) => _name = name;

        public string GetProductId() => _productId;
        public void SetProductId(string productId) => _productId = productId;

        public decimal GetPrice() => _price;
        public void SetPrice(decimal price) => _price = price;

        public int GetQuantity() => _quantity;
        public void SetQuantity(int quantity) => _quantity = quantity;

        //Computes the total cost by multiplying unit price by quantity
        public decimal GetTotalCost()
        {
            return _price * _quantity;
        }
    }
}