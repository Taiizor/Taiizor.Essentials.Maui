using Taiizor.Essentials.Maui.AppCenter.Services;
using Taiizor.Essentials.Maui.AppCenter.Value;

namespace Taiizor.Essentials.Maui.AppCenter.Helper
{
    internal class Watch
    {
        public static string GetText(string Title)
        {
            return string.Format(Internal.AppCenterWatch.Format, Internal.AppCenterWatch.Prefix, Internal.AppCenterWatch.Name, Title, AppCenterService.UserId, Internal.AppCenterWatch.Suffix);
        }
    }
}