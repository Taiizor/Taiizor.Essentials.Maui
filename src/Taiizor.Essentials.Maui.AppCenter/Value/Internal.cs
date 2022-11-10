using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Struct;

namespace Taiizor.Essentials.Maui.AppCenter.Value
{
    internal class Internal
    {
        public static string Unknown = "Unknown";

        public static bool AppCenterState = false;

        public static WatchStruct AppCenterWatch = new()
        {
            Format = "{0}-{1}{2}-{3}-{4}",
            Attachments = "Attachments",
            Properties = "Properties",
            PropertiesError = "Error",
            PropertiesEvent = "Name",
            Event = WatchEnum.Close,
            Error = WatchEnum.Close,
            EventName = "Event",
            ErrorName = "Error",
            Prefix = "Prefix",
            Suffix = "Suffix",
            Name = "Watch"
        };

        public static Dictionary<AppEnum, string> AppCenterKey = new()
        {
            { AppEnum.iOS, "{Your iOS App secret here}" },
            { AppEnum.macOS, "{Your macOS App secret here}" },
            { AppEnum.Android, "{Your Android App secret here}" },
            { AppEnum.Windows, "{Your Windows App secret here}" }
        };

        public static string AppCenterKeyFormat = "ios={0};macos={1};android={2};windowsdesktop={3};";

        public static string AppCenterMobileKeyFormat = "ios={0};android={1};";

        public static string AppCenterDesktopKeyFormat = "macos={0};windowsdesktop={1};";

        public const string EnvironmentToken = "MAUI_TAIIZOR_{0}_TARGET_TOKEN";

        public const EnvironmentVariableTarget EnvironmentTarget = EnvironmentVariableTarget.User;
    }
}