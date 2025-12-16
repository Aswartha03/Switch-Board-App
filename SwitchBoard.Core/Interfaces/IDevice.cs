using SwitchBoard.Core.Enums;

namespace SwitchBoard.Core.Interfaces
{
    public interface IDevice
	{
        public DeviceTypes Name { get; set; }
        public bool IsDeviceOn { get; set; }
	}
}
