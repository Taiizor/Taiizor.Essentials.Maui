using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;

namespace Taiizor.Essentials.Maui.Platforms.Services
{
    internal class AppCenterService
    {
        public static void Start()
        {
            AppCenter.Start(Internal.AppCenterKey[AppEnum.iOS], typeof(Analytics), typeof(Crashes));

            Internal.AppCenterState = true;
        }
    }
}