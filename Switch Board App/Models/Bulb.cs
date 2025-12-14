using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Constants;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Models
{
	public class Bulb : IDevice
	{
		public string Name { get; set; } = DeviceNames.Bulb;
		public bool IsDeviceOn { get; set; }

		
	}
}
