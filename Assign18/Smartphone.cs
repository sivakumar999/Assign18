using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign18
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

        public Smartphone(string model)
        {
            Model = model;
            BatteryLevel = 100;
        }

        public bool Connect()
        {
            Console.WriteLine($"Connecting {Model}...");
            IsConnected = true;
            return IsConnected;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"Charging {Model} for {minutes} minutes...");
            BatteryLevel += minutes / 10;
            BatteryLevel = Math.Min(BatteryLevel, 100);
        }

        public string Display()
        {
            return $"Smartphone Model: {Model}, Battery Level: {BatteryLevel}%";
        }
    }
}
