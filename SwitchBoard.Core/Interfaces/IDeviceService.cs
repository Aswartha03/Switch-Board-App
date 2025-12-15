
namespace SwitchBoard.Core.Interfaces
{
    public interface IDeviceService
    {
        public void RetriveDevices(List<IDevice> devices);
        public void AddDevices(int fanCount, int acCount, int bulbCount, List<IDevice> devices);
        public void ModifyDeviceStatus(IDevice device);
	}
}
