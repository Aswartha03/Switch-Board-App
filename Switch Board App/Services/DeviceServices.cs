using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Constants;
using Switch_Board_App.Interfaces;
using Switch_Board_App.Models;

namespace Switch_Board_App.Services
{
    public static class DeviceServices
    {
		// Retrieve all devices
		public static void RetriveDevices(List<IDevice> devices)
		{
			int currDeviceNumber = 1;
			foreach (IDevice device in devices)
			{
				string deviceState = device.IsDeviceOn ? "On" : "Off";
				Console.WriteLine($"{currDeviceNumber} . {device.Name} is {deviceState}");
				currDeviceNumber++;
			}
		}

		// Add devices to the list
		static public void AddDevices(int fans, int acs, int bulbs, List<IDevice> devices)
		{

			while (fans > 0)
			{
				devices.Add(new Device(DeviceNames.Fan));
				fans--;
			}
			while (acs > 0)
			{
				devices.Add(new Device(DeviceNames.Ac));
				acs--;
			}
			while (bulbs > 0)
			{
				devices.Add(new Device(DeviceNames.Bulb));
				bulbs--;
			}

		}

		// Modify Device Status
		static public void ModifyDeviceStatus(IDevice device)
		{
			string optionToUser = device.IsDeviceOn ? "Off" : "On";

			Console.WriteLine($"1 . Switch {device.Name} {optionToUser}");
			Console.WriteLine("2 . Back");

			Console.Write("Enter Your Option : ");

			int userChoice = Convert.ToInt32(Console.ReadLine());

			if (userChoice == 1)
			{
				if (optionToUser == "Off") { device.IsDeviceOn = false; }
				else { device.IsDeviceOn = true; }
			}
		}
	}
}
