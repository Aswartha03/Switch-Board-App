using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Models
{
	static class DisplayDevices
	{
		static public void RetriveDevices(List<IDevice> devices)
		{
			for (int i = 0; i < devices.Count; i++)
			{
				IDevice device = devices[i];
				string deviceStatus = device.DisplayStatus();
				Console.WriteLine($"{i + 1} . {deviceStatus}");
			}
		}
	}
}
