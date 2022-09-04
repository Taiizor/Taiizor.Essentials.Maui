using Taiizor.Essentials.Maui.AppCenter.Enum;

namespace Taiizor.Essentials.Maui.AppCenter.Value
{
    internal class Internal
    {
        public static bool AppCenterState = false;

        public static Dictionary<AppEnum, string> AppCenterKey = new()
        {
            { AppEnum.iOS, "{Your iOS App secret here}" },
            { AppEnum.macOS, "{Your macOS App secret here}" },
            { AppEnum.Android, "{Your Android App secret here}" },
            { AppEnum.Windows, "{Your Windows App secret here}" }
        };
    }
}