using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Value;
using APP = Taiizor.Essentials.Maui.AppCenter.Helper.App;

namespace Taiizor.Essentials.Maui.AppCenter.Helper
{
    public class Key
    {
        internal static string GetText(Dictionary<AppEnum, string> Keys)
        {
#if WINDOWS || MACCATALYST
            return string.Format(Internal.AppCenterDesktopKeyFormat, Keys[AppEnum.macOS], Keys[AppEnum.Windows]);
#elif ANDROID || IOS
            return string.Format(Internal.AppCenterMobileKeyFormat, Keys[AppEnum.iOS], Keys[AppEnum.Android]);
#else
            return string.Format(Internal.AppCenterKeyFormat, Keys[AppEnum.iOS], Keys[AppEnum.macOS], Keys[AppEnum.Android], Keys[AppEnum.Windows]);
#endif
        }

        internal static string GetText(string Key, string Format)
        {
            return string.Format(Format, Key);
        }

        public static bool SetVariable(AppEnum App, string Value, string Format = Internal.EnvironmentToken, EnvironmentVariableTarget Target = Internal.EnvironmentTarget)
        {
            return SetVariable(APP.GetApp(App), Value, Format, Target);
        }

        public static string GetVariable(AppEnum App, string Format = Internal.EnvironmentToken, EnvironmentVariableTarget Target = Internal.EnvironmentTarget)
        {
            return GetVariable(APP.GetApp(App), Format, Target);
        }

        public static bool SetVariable(string Key, string Value, string Format = Internal.EnvironmentToken, EnvironmentVariableTarget Target = Internal.EnvironmentTarget)
        {
            try
            {
                Environment.SetEnvironmentVariable(GetText(Key, Format), Value, Target);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetVariable(string Key, string Format = Internal.EnvironmentToken, EnvironmentVariableTarget Target = Internal.EnvironmentTarget)
        {
            try
            {
                return Environment.GetEnvironmentVariable(GetText(Key, Format), Target);
            }
            catch
            {
                return "{Your " + Key + " App secret here}";
            }
        }
    }
}