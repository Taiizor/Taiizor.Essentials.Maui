using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Reload
    {
        public static async ValueTask Page()
        {
            await Page(true);
        }

        public static async ValueTask Page(bool Redirect)
        {
            if (Redirect)
            {
                await Interop.JS.InvokeVoidAsync("Reload");
            }
        }

        public static async ValueTask Element(string Identify)
        {
            await Element(Identify, true);
        }

        public static async ValueTask Element(string Identify, bool Method)
        {
            await Interop.JS.InvokeVoidAsync("ReloadElement", Identify, Method);
        }
    }
}