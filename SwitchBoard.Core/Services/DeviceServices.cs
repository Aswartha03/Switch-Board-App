using SwitchBoard.Core.Models;
using SwitchBoard.Core.Enums;
using SwitchBoard.Core.Interfaces;

namespace SwitchBoard.Core.Services
{
    public class DeviceServices  : IDeviceService
    {
		// Retrieve all devices
		public  void RetriveDevices(List<IDevice> devices)
		{
			int currDeviceNumber = 1;
			foreach (IDevice device in devices)
			{
				DeviceStatus deviceState = device.IsDeviceOn ?  DeviceStatus.On : DeviceStatus.Off;
				Console.WriteLine($"{currDeviceNumber} . {device.Name} is {deviceState}");
				currDeviceNumber++;
			}
		}

		// Add devices to the list
		 public void AddDevices(int fanCount, int acCount, int bulbCount, List<IDevice> devices)
		{
			while (fanCount > 0)
			{
				devices.Add(new Device(DeviceTypes.Fan));
				fanCount--;
			}
			while (acCount > 0)
			{
				devices.Add(new Device(DeviceTypes.Ac));
				acCount--;
			}
			while (bulbCount > 0)
			{
				devices.Add(new Device(DeviceTypes.Bulb));
				bulbCount--;
			}
		}

		// Modify Device Status
		 public void ModifyDeviceStatus(IDevice device)
		{
			DeviceStatus optionToUser = device.IsDeviceOn ? DeviceStatus.Off : DeviceStatus.On;
			Console.WriteLine($"1 . Switch {device.Name} {optionToUser}");
			Console.WriteLine("2 . Back");
			Console.Write("Enter Your Option : ");
			int userChoice = Convert.ToInt32(Console.ReadLine());
			if (userChoice == 1)
			{
				if (optionToUser == DeviceStatus.Off) { device.IsDeviceOn = false; }
				else { device.IsDeviceOn = true; }
			}
		}
	}
}
