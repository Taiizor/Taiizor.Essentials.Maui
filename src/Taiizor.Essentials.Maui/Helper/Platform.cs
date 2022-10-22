using Taiizor.Essentials.Maui.Enum;

namespace Taiizor.Essentials.Maui.Helper
{
    public class Platform
    {
        public static PlatformEnum GetPlatform
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
    }
}