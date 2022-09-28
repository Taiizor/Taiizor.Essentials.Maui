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
                JavascriptEnum.Custom => string.Format(Internal.JavascriptFile, "custom"),
                JavascriptEnum.Taiizor => string.Format(Internal.JavascriptFile, "taiizor"),
                JavascriptEnum.AppCenter => string.Format(Internal.JavascriptFile, "appcenter"),
                _ => string.Format(Internal.JavascriptFile, "none"),
            };
        }
    }
}