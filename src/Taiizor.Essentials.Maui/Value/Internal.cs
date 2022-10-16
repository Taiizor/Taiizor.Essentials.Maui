using Taiizor.Essentials.Maui.Enum;

namespace Taiizor.Essentials.Maui.Value
{
    internal class Internal
    {
        public static readonly string DefaultCulture = "en-GB";

        public static readonly string CacheDirectory = FileSystem.Current.CacheDirectory;

        public static readonly string DataDirectory = FileSystem.Current.AppDataDirectory;

        public static readonly string StorageExtension = ".json";

        public static readonly string JavascriptFile = "Taiizor.Essentials.Maui.Resources.Raw.{0}.Blazor.js";


        public static Dictionary<JavascriptEnum, bool> JavascriptFiles = new()
        {
            { JavascriptEnum.Custom, true },
            { JavascriptEnum.Taiizor, true },
            { JavascriptEnum.AppCenter, true },
            { JavascriptEnum.Conforyon, true }
        };
    }
}