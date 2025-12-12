using System;
using System.Collections.Generic;
using System.Text;

namespace Switch_Board_App.Interfaces
{
    public interface IDevice
    {
        public string Name { get; set; }
		public bool IsDeviceOn { get; set; } 
        public void TurnOn();
        public void TurnOff();

        public string DisplayStatus();
        
	}
}
