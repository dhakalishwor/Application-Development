using System;

namespace Week5.OOP
{
    internal abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Brand cannot be empty.");
                brand = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price must be greater than zero.");
                price = value;
            }
        }

        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public abstract void ShowInfo();
    }
}