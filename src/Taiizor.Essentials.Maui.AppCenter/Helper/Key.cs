using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Value;

namespace Taiizor.Essentials.Maui.AppCenter.Helper
{
    internal class Key
    {
        public static string GetText(Dictionary<AppEnum, string> Keys)
        {
#if WINDOWS || MACCATALYST
            return string.Format($"{Internal.AppCenterDesktopKeyFormat}", Keys[AppEnum.macOS], Keys[AppEnum.Windows]);
#elif ANDROID || IOS
            return string.Format($"{Internal.AppCenterMobileKeyFormat}", Keys[AppEnum.iOS], Keys[AppEnum.Android]);
#else
            return string.Format($"{Internal.AppCenterKeyFormat}", Keys[AppEnum.iOS], Keys[AppEnum.macOS], Keys[AppEnum.Android], Keys[AppEnum.Windows]);
#endif
        }
    }
}