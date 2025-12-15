using SwitchBoard.Core.Interfaces;
using SwitchBoard.Core.Services;

namespace SwitchBoard.App
{
    internal class Program
    {
		static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Switch Board App");
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
			// Creating DeviceService Object and  Using Device Services
			DeviceServices deviceServices = new DeviceServices(); 
			// Adding devices to the list
			deviceServices.AddDevices(numberOfFans, numberOfAcs, numberOfBulbs, devices);
			int choice = 0;
            do
            {
                Console.WriteLine("Device Menu : \n");
				// Retrieving all devices
				deviceServices.RetriveDevices(devices);
				Console.WriteLine($"{totalDevices + 1}. Exit");
                Console.WriteLine("Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                // If Choice is Valid
                if (choice <= totalDevices) 
                {
                    IDevice selectedDevice = devices[choice - 1];
					// Modifying Device Status
					deviceServices.ModifyDeviceStatus(selectedDevice);
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
            while (choice <= totalDevices + 1);
        }
    }
}
