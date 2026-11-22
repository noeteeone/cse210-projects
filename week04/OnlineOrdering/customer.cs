using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
    public class Customer
    {
        private string _name;
        private Address _customerAddress;

        public Customer(string name, Address address)
        {
            _name = name;
            _customerAddress = address;
        }
        //Getters and Setters
        public string GetName() => _name;
        public void SetName(string name) => _name = name;

        public Address GetCustomerAddress() => _customerAddress;
        public void SetCustomerAddress(Address address) => _customerAddress = address;

        //Delegates the country check to the address class method
        public bool LivesInUSA()
        {
            return _customerAddress.IsInUSA();
            Console.WriteLine();
        }
    }
}
