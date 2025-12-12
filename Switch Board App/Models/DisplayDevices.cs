using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Models
{
    static internal class DisplayDevices
    {
		static public void RetriveDevices(List<IDevice> devices)
		{
			int currDeviceNumber = 1;
			foreach (IDevice device in devices)
			{
				string deviceStatus = device.DisplayStatus();
				Console.WriteLine($"{currDeviceNumber} . {deviceStatus}");
				currDeviceNumber++;
			}
		}
	}
}
