using Microsoft.JSInterop;

namespace Taiizor.Essentials.Extension
{
    public class Redirect
    {

        public static async void GoLocation()
        {
            await GoLocation("/");
        }

        [JSInvokable]
        public static async Task GoLocation(string Uri)
        {
            await Interop.JS.InvokeVoidAsync("GoLocation", Uri);
        }
    }
}