using System.Text;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Project
    {
        public static string Name = AppInfo.Current.Name;

        public static string PackageName = AppInfo.Current.PackageName;

        public static Version Version => AppInfo.Current.Version;

        public static string VersionString => AppInfo.Current.VersionString;

        public static string BuildString => AppInfo.Current.BuildString;

        public static AppTheme RequestedTheme => AppInfo.Current.RequestedTheme;

        public static string RequestedThemeString => RequestedTheme.ToString();

        public static AppPackagingModel PackagingModel => AppInfo.Current.PackagingModel;

        public static string PackagingModelString => PackagingModel.ToString();

        public static LayoutDirection RequestedLayoutDirection => AppInfo.Current.RequestedLayoutDirection;

        public static string RequestedLayoutDirectionString => RequestedLayoutDirection.ToString();

        public static void ShowSettings()
        {
            AppInfo.Current.ShowSettingsUI();
        }

        public static string Info()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Build: {BuildString}");
            stringBuilder.AppendLine($"Package: {PackageName}");
            stringBuilder.AppendLine($"Theme: {RequestedTheme}");
            stringBuilder.AppendLine($"Model: {PackagingModel}");
            stringBuilder.AppendLine($"Version: {VersionString}");
            stringBuilder.AppendLine($"Direction: {RequestedLayoutDirection}");

            return stringBuilder.ToString();
        }
    }
}