using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Helper
{
    public class Reload
    {
        public static async ValueTask Element(string Identify, bool Method = true)
        {
            await Interop.JS.InvokeVoidAsync("ReloadElement", Identify, Method);
        }
    }
}