using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.AppCenter.Services;

namespace Taiizor.Essentials.Maui.AppCenter.Watch
{
    public class Event
    {
        [JSInvokable("WatchEventBasic")]
        //[JSInvokableAttribute("WatchEventBasic")]
        public static void WatchBasic(string Name)
        {
            AppCenterService.WatchEvent(Name);
        }

        [JSInvokable("WatchEventNormal")]
        //[JSInvokableAttribute("WatchEventNormal")]
        public static void WatchNormal(string Name, string Key, string Value)
        {
            AppCenterService.WatchEvent(Name, new Dictionary<string, string>() { { Key, Value } });
        }

        [JSInvokable("WatchEventAdvanced")]
        //[JSInvokableAttribute("WatchEventAdvanced")]
        public static void WatchAdvanced(string Name, IDictionary<string, string> Properties = null)
        {
            AppCenterService.WatchEvent(Name, Properties);
        }
    }
}