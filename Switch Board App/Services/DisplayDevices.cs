using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Services
{
	static class DisplayDevices
	{
		static public void RetriveDevices(List<IDevice> devices)
		{
			int currDeviceNumber = 1;
			foreach (IDevice device in devices)
			{
				string deviceState = device.IsDeviceOn ? "On" : "Off";
				Console.WriteLine($"{currDeviceNumber} . {device.Name} is {deviceState}");
				currDeviceNumber++; 
			}
		}
	}
}
