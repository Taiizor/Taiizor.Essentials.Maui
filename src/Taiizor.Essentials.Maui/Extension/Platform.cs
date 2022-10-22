using System.Text;
using Taiizor.Essentials.Maui.Enum;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Platform
    {
        public static PlatformEnum Type
        {
#if MACCATALYST
            get => PlatformEnum.MacCatalyst;
#elif ANDROID
            get => PlatformEnum.Android;
#elif IOS
            get => PlatformEnum.iOS;
#else
            get => PlatformEnum.WinUI;
#endif
        }

        public static string TypeString => Type.ToString();

        public static string Info()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"Type: {TypeString}");

            return stringBuilder.ToString();
        }
    }
}