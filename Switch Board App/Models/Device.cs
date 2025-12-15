using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Switch_Board_App.Interfaces;

namespace Switch_Board_App.Models
{
    public class Device : IDevice
    {
        public string Name { get; set; }
        public bool IsDeviceOn { get; set; }
        public Device(string name)
        {
            Name = name;
        }
    }
    
}
