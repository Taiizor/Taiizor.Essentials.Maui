using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Class
    {
        public static async ValueTask Add(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("AddClass", Identify, Class);
        }

        public static async ValueTask Add(string Identify, params string[] Classes)
        {
            foreach (string Class in Classes)
            {
                await Add(Identify, Class);
            }
        }

        public static async ValueTask Set(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("SetClass", Identify, Class);
        }

        public static async ValueTask Toggle(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("ToggleClass", Identify, Class);
        }

        public static async ValueTask Toggle(string Identify, params string[] Classes)
        {
            foreach (string Class in Classes)
            {
                await Toggle(Identify, Class);
            }
        }

        public static async ValueTask Remove(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("RemoveClass", Identify, Class);
        }

        public static async ValueTask Remove(string Identify, params string[] Classes)
        {
            foreach (string Class in Classes)
            {
                await Remove(Identify, Class);
            }
        }
    }
}