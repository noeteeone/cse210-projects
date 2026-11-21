using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
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
        //Getters and Setters
        public string GetStreetAddress() => _streetAddress;
        public void SetStreetAddress(string streetAddress) => _streetAddress = streetAddress;

        public string GetCity() => _city;
        public void SetCity(string city) => _city = city;

        public string GetStateProvince() => _stateProvince;
        public void SetStateProvince(string stateProvince) => _stateProvince = stateProvince;

        public string GetCountry() => _country;
        public void SetCountry(string country) => _country = country;

        //Returns true if the country is the USA (case-insensitive check)
        public bool IsInUSA()
        {
            return _country.Equals("USA", StringComparison.OrdinalIgnoreCase) || _country.Equals("United States", StringComparison.OrdinalIgnoreCase);
        }
        //Formats all address fields into a single printable block
        public string GetFullAddressString()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}