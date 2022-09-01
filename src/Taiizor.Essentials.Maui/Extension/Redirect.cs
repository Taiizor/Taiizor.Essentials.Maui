using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Redirect
    {

        public static async void GoLocation()
        {
            await GoLocation("/");
        }

        [JSInvokable]
        public static async ValueTask GoLocation(string Uri)
        {
            await Interop.JS.InvokeVoidAsync("GoLocation", Uri);
        }
    }
}