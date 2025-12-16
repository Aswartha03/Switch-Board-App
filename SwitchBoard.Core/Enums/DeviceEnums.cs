
using System.ComponentModel;


namespace SwitchBoard.Core.Enums
{
    public enum DeviceTypes
    {
        [Description("Fan")]
        Fan,

        [Description("Ac")]
        Ac,

        [Description("Bulb")]
        Bulb 
    }
    public enum DeviceStatus
    {
        [Description("On")]
        On,

        [Description("Off")]
		Off
    }
}

