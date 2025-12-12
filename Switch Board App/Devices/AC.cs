using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Devices
{
	internal class AC : IDevice
	{

		public string Name { get; set; } = "AC";
		public bool IsDeviceOn { get; set; } = false;
		public void TurnOff()
		{
			IsDeviceOn = false;
		}
		public void TurnOn()
		{
			IsDeviceOn = true;
		}

		public string DisplayStatus()
		{
			string status = IsDeviceOn ? "On" : "Off";
			return $"AC is {status}";
		}
	}
}
