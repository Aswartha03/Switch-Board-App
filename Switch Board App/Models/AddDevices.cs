using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Devices;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Models
{
    static internal class AddDevices
    {
		static public void AddToDevices(int fans, int acs, int bulbs, List<IDevice> devices)
		{
			int totalDevices = fans + acs + bulbs;
			for (int i = 0; i < totalDevices; i++)
			{
				while (fans > 0)
				{
					devices.Add(new Fan());
					fans--;
				}
				while (acs > 0)
				{
					devices.Add(new AC());
					acs--;
				}
				while (bulbs > 0)
				{
					devices.Add(new Bulb());
					bulbs--;
				}
			}
		}
	}
}
