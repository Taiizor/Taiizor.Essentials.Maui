using System.Text;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Device
    {
        public static string Name => DeviceInfo.Current.Name;

        public static string Model => DeviceInfo.Current.Model;

        public static DeviceIdiom Idiom => DeviceInfo.Current.Idiom;

        public static string IdiomString => Idiom.ToString();

        public static DevicePlatform Platform => DeviceInfo.Current.Platform;

        public static string PlatformString => Platform.ToString();

        public static string Manufacturer => DeviceInfo.Current.Manufacturer;

        public static Version Version => DeviceInfo.Version;

        public static string VersionString => DeviceInfo.VersionString;

        public static DeviceType DeviceType => DeviceInfo.Current.DeviceType;

        public static string DeviceTypeString => DeviceType.ToString();

        public static string ReadDeviceInfo()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Model: {Model}");
            stringBuilder.AppendLine($"Idiom: {IdiomString}");
            stringBuilder.AppendLine($"Version: {VersionString}");
            stringBuilder.AppendLine($"Platform: {PlatformString}");
            stringBuilder.AppendLine($"Manufacturer: {Manufacturer}");
            stringBuilder.AppendLine($"DeviceType: {DeviceTypeString}");

            return stringBuilder.ToString();
        }
    }
}