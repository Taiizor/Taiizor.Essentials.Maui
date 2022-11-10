using System.Reflection;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;

namespace Taiizor.Essentials.Maui.Helper
{
    internal class Javascript
    {
        public static string GetFile(JavascriptEnum Javascript)
        {
            return Javascript switch
            {
                JavascriptEnum.Custom => string.Format(Internal.JavascriptFile, "Custom"),
                JavascriptEnum.Taiizor => string.Format(Internal.JavascriptFile, "Taiizor"),
                JavascriptEnum.AppCenter => string.Format(Internal.JavascriptFile, "AppCenter"),
                JavascriptEnum.Conforyon => string.Format(Internal.JavascriptFile, "Conforyon"),
                _ => string.Format(Internal.JavascriptFile, "None"),
            };
        }

        public static string LoadFile(JavascriptEnum Javascript)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = GetFile(Javascript);

            using Stream? stream = assembly.GetManifestResourceStream(resourceName);

            using StreamReader reader = new(stream);

            return reader.ReadToEnd();
        }
    }
}