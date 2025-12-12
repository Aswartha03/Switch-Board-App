using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Switch_Board_App.Devices;
using Switch_Board_App.Interfaces;
using Switch_Board_App.Models;

namespace Switch_Board_App
{
    internal class Program
    {

        static void Main(string[] args)
        {

		Console.WriteLine("Switch Board Console Application : \n ");

            // Store all Devices :
            List<IDevice> devices = new List<IDevice>();

            Console.WriteLine("Adding Devices to Switch Board...");

			// Asking user for number of devices to add

			Console.Write("Number of Fans to add: ");
            int numberOfFans = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Acs to add: ");
            int numberOfAcs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Bulbs to add : ");
            int numberOfBulbs = Convert.ToInt32(Console.ReadLine());


			int totalDevices = numberOfBulbs + numberOfFans + numberOfAcs;
			// Adding devices to the list
			AddDevices.AddToDevices(numberOfFans, numberOfAcs, numberOfBulbs, devices);

            int choice = 0;

            do
            {
                Console.WriteLine("Device Menu : \n"); 

                DisplayDevices.RetriveDevices(devices);
                Console.WriteLine($"{totalDevices + 1}. Exit");

                Console.WriteLine("Enter Your Choice : ");

                choice = Convert.ToInt32(Console.ReadLine());

                // Choice is Valid
                if (choice <= totalDevices)
                {
                    IDevice selectedDevice = devices[choice - 1];

                    ModifyDevice.Modify(selectedDevice);
                }

                // User try to exit the app
                else if (choice == totalDevices + 1)
                {
                    Console.WriteLine("Exiting the Program");
                    break;
                }

                else
                // Invalid Case
                {
                    Console.WriteLine("Invalid Case , Exiting the Program");
                    break;
                }
            }
			while (choice <= totalDevices+1);

        }
    }
}
