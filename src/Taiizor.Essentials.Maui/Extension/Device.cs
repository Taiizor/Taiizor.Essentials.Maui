using System.Text;
using Taiizor.Essentials.Maui.Enum;
using EP = Taiizor.Essentials.Maui.Extension.Platform;

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

        public static DeviceType Type => DeviceInfo.Current.DeviceType;

        public static string TypeString => Type.ToString();

        public static DeviceEnum Kind => EP.Type switch
        {
            PlatformEnum.iOS => DeviceEnum.iPhone,
            PlatformEnum.Android => DeviceEnum.Android,
            PlatformEnum.MacCatalyst => DeviceEnum.MacBook,
            _ => DeviceEnum.Windows,
        };

        public static string KindString => Kind.ToString();

        public static DeviceTypeEnum KindType => EP.Type switch
        {
            PlatformEnum.iOS or PlatformEnum.Android => DeviceTypeEnum.Mobile,
            _ => DeviceTypeEnum.Desktop,
        };

        public static string KindTypeString => KindType.ToString();

        public static string Info()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Model: {Model}");
            stringBuilder.AppendLine($"Type: {TypeString}");
            stringBuilder.AppendLine($"Kind: {KindString}");
            stringBuilder.AppendLine($"Idiom: {IdiomString}");
            stringBuilder.AppendLine($"Version: {VersionString}");
            stringBuilder.AppendLine($"Platform: {PlatformString}");
            stringBuilder.AppendLine($"Kind Type: {KindTypeString}");
            stringBuilder.AppendLine($"Manufacturer: {Manufacturer}");

            return stringBuilder.ToString();
        }
    }
}