using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Helper
{
    public class Include
    {
        public static async ValueTask Script(string Path)
        {
            await Interop.JS.InvokeVoidAsync("Include", Path);
        }
    }
}