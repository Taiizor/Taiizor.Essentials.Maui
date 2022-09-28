using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.AppCenter.Services;

namespace Taiizor.Essentials.Maui.AppCenter.Track
{
    public class Event
    {
        [JSInvokable("TrackEventBasic")]
        //[JSInvokableAttribute("TrackEventBasic")]
        public static void TrackBasic(string Name)
        {
            AppCenterService.TrackEvent(Name);
        }

        [JSInvokable("TrackEventNormal")]
        //[JSInvokableAttribute("TrackEventNormal")]
        public static void TrackNormal(string Name, string Key, string Value)
        {
            AppCenterService.TrackEvent(Name, new Dictionary<string, string>() { { Key, Value } });
        }

        [JSInvokable("TrackEventAdvanced")]
        //[JSInvokableAttribute("TrackEventAdvanced")]
        public static void TrackAdvanced(string Name, IDictionary<string, string> Properties = null)
        {
            AppCenterService.TrackEvent(Name, Properties);
        }
    }
}