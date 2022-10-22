using Taiizor.Essentials.Maui.Enum;

namespace Taiizor.Essentials.Maui.Helper
{
    public class Device
    {
        public static DeviceEnum GetDevice => Platform.GetPlatform switch
        {
            PlatformEnum.iOS => DeviceEnum.iPhone,
            PlatformEnum.Android => DeviceEnum.Android,
            PlatformEnum.MacCatalyst => DeviceEnum.MacBook,
            _ => DeviceEnum.Windows,
        };

        public static DeviceTypeEnum GetDeviceType => Platform.GetPlatform switch
        {
            PlatformEnum.iOS or PlatformEnum.Android => DeviceTypeEnum.Mobile,
            _ => DeviceTypeEnum.Desktop,
        };
    }
}