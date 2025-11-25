using System;
using System.Collections.Generic;

namespace Week5.OOP
{
    internal class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to store.");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"{device.Brand} removed from store.");
            }
            else
            {
                Console.WriteLine("Device not found in store.");
            }
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("Listing all devices:\n");

            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcasting to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}