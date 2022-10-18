using Taiizor.Essentials.Maui.AppCenter.Enum;

namespace Taiizor.Essentials.Maui.AppCenter.Helper
{
    internal class App
    {
        public static string GetApp(AppEnum App)
        {
            return App switch
            {
                AppEnum.iOS => "IOS",
                AppEnum.macOS => "MACOS",
                AppEnum.Android => "ANDROID",
                _ => "WINDOWS",
            };
        }
    }
}