using Microsoft.AppCenter.Crashes;
using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.AppCenter.Services;

namespace Taiizor.Essentials.Maui.AppCenter.Watch
{
    public class Error
    {
        [JSInvokable("WatchErrorBaby")]
        //[JSInvokableAttribute("WatchErrorBaby")]
        public static void WatchBaby(string Name)
        {
            AppCenterService.WatchError(Name);
        }

        [JSInvokable("WatchErrorBasic")]
        //[JSInvokableAttribute("WatchErrorBasic")]
        public static void WatchBasic(Exception Exception)
        {
            AppCenterService.WatchError(Exception);
        }

        [JSInvokable("WatchErrorNormal")]
        //[JSInvokableAttribute("WatchErrorNormal")]
        public static void WatchNormal(Exception Exception, string Key, string Value)
        {
            AppCenterService.WatchError(Exception, new Dictionary<string, string>() { { Key, Value } });
        }

        [JSInvokable("WatchErrorAdvanced")]
        //[JSInvokableAttribute("WatchErrorAdvanced")]
        public static void WatchAdvanced(Exception Exception, IDictionary<string, string> Properties = null)
        {
            AppCenterService.WatchError(Exception, Properties);
        }

        [JSInvokable("WatchErrorHard")]
        //[JSInvokableAttribute("WatchErrorHard")]
        public static void WatchHard(Exception Exception, IDictionary<string, string> Properties = null, ErrorAttachmentLog[] Attachments = null)
        {
            AppCenterService.WatchError(Exception, Properties, Attachments);
        }
    }
}