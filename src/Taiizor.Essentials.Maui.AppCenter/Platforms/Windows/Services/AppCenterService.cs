using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Taiizor.Essentials.Maui.AppCenter.Value;
using AC = Microsoft.AppCenter.AppCenter;
using HK = Taiizor.Essentials.Maui.AppCenter.Helper.Key;

namespace Taiizor.Essentials.Maui.AppCenter.Platforms.Services
{
    internal class AppCenterService
    {
        public static void Start()
        {
            AC.Start(HK.GetText(Internal.AppCenterKey), typeof(Analytics), typeof(Crashes)); //Internal.AppCenterKey[AppEnum.Windows]

            Internal.AppCenterState = true;
        }
    }
}