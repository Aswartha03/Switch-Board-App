
using SwitchBoard.Core.Enums;
using SwitchBoard.Core.Interfaces;

namespace SwitchBoard.Core.Models
{
    public class Device : IDevice
    {
        public DeviceTypes Name { get; set; }
        public bool IsDeviceOn { get; set; }

        public Device(DeviceTypes name)
        {
            Name = name;
        }
    }
    
}
