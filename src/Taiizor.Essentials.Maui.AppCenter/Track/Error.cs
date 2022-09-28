using Microsoft.AppCenter.Crashes;
using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.AppCenter.Services;

namespace Taiizor.Essentials.Maui.AppCenter.Track
{
    public class Error
    {
        [JSInvokable("TrackErrorBasic")]
        //[JSInvokableAttribute("TrackErrorBasic")]
        public static void TrackBasic(Exception Exception)
        {
            AppCenterService.TrackError(Exception);
        }

        [JSInvokable("TrackErrorNormal")]
        //[JSInvokableAttribute("TrackErrorNormal")]
        public static void TrackNormal(Exception Exception, string Key, string Value)
        {
            AppCenterService.TrackError(Exception, new Dictionary<string, string>() { { Key, Value } });
        }

        [JSInvokable("TrackErrorAdvanced")]
        //[JSInvokableAttribute("TrackErrorAdvanced")]
        public static void TrackAdvanced(Exception Exception, IDictionary<string, string> Properties = null)
        {
            AppCenterService.TrackError(Exception, Properties);
        }

        [JSInvokable("TrackErrorHard")]
        //[JSInvokableAttribute("TrackErrorHard")]
        public static void TrackHard(Exception Exception, IDictionary<string, string> Properties = null, string Text = "Hello World!", string TextFile = "Hello.txt", string Image = "Fake Image", string ImageFile = "fake_image.jpeg", string Extension = "image/jpeg")
        {
            AppCenterService.TrackError(Exception, Properties, Text, TextFile, Image, ImageFile, Extension);
        }

        [JSInvokable("TrackErrorExpert")]
        //[JSInvokableAttribute("TrackErrorExpert")]
        public static void TrackExpert(Exception Exception, IDictionary<string, string> Properties = null, string Text = "Hello World!", string TextFile = "Hello.txt", byte[] Image = null, string ImageFile = "fake_image.jpeg", string Extension = "image/jpeg")
        {
            AppCenterService.TrackError(Exception, Properties, Text, TextFile, Image, ImageFile, Extension);
        }

        [JSInvokable("TrackErrorGod")]
        //[JSInvokableAttribute("TrackErrorGod")]
        public static void TrackGod(Exception Exception, IDictionary<string, string> Properties = null, ErrorAttachmentLog[] Attachments = null)
        {
            AppCenterService.TrackError(Exception, Properties, Attachments);
        }
    }
}