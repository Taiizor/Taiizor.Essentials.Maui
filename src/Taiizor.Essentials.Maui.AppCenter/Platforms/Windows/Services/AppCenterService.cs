using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Value;
using AC = Microsoft.AppCenter.AppCenter;

namespace Taiizor.Essentials.Maui.AppCenter.Platforms.Services
{
    internal class AppCenterService
    {
        public static void Start()
        {
            AC.Start(Internal.AppCenterKey[AppEnum.Windows], typeof(Analytics), typeof(Crashes));

            Internal.AppCenterState = true;
        }
    }
}