using System;
using System.Collections.Generic;
using System.Text;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Services
{
	static internal class ModifyDevice 
	{
		static public void Modify(IDevice device)
        {
			string optionToUser = device.IsDeviceOn ? "Off" : "On";

			Console.WriteLine($"1 . Switch {device.Name} {optionToUser}");
			Console.WriteLine("2 . Back");

			Console.Write("Enter Your Option : ");

			int userChoice = Convert.ToInt32(Console.ReadLine());

			if (userChoice == 1)
			{
				if (optionToUser == "Off") {device.IsDeviceOn = false; }
				else { device.IsDeviceOn = true; }
			}
		}
	}
}
