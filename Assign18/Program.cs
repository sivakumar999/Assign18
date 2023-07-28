using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;

            while (continueLoop)
            {
                Console.Write("Enter Smartphone Model: ");
                string smartphoneModel = Console.ReadLine();
                Smartphone smartphone = new Smartphone(smartphoneModel);
                Console.Write("Enter Laptop Model: ");
                string laptopModel = Console.ReadLine();
                Laptop laptop = new Laptop(laptopModel);
                smartphone.Connect();
                laptop.Connect();
                Console.Write("Enter Charging Time for Smartphone (in minutes): ");
                int smartphoneChargeTime = int.Parse(Console.ReadLine());

                Console.Write("Enter Charging Time for Laptop (in minutes): ");
                int laptopChargeTime = int.Parse(Console.ReadLine());

                 smartphone.Charge(smartphoneChargeTime);
                laptop.Charge(laptopChargeTime);

                Console.WriteLine(smartphone.Display());
                Console.WriteLine(laptop.Display());
                // Ask the user if they want to continue
                Console.Write("Do you want to continue (Y/N)? ");
                string userInput = Console.ReadLine().Trim();
                continueLoop = (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase));
            }

            Console.WriteLine("Exiting the program. Press any key to close.");
            Console.ReadKey();
        }
    }
}
