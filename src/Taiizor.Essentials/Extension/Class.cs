using Microsoft.JSInterop;

namespace Taiizor.Essentials.Extension
{
    public class Class
    {
        public static async Task Add(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("AddClass", Identify, Class);
        }

        public static async Task Add(string Identify, params string[] Classes)
        {
            foreach (string Class in Classes)
            {
                await Add(Identify, Class);
            }
        }

        public static async Task Set(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("SetClass", Identify, Class);
        }

        public static async Task Toggle(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("ToggleClass", Identify, Class);
        }

        public static async Task Toggle(string Identify, params string[] Classes)
        {
            foreach (string Class in Classes)
            {
                await Toggle(Identify, Class);
            }
        }

        public static async Task Remove(string Identify, string Class)
        {
            await Interop.JS.InvokeVoidAsync("RemoveClass", Identify, Class);
        }

        public static async Task Remove(string Identify, params string[] Classes)
        {
            foreach (string Class in Classes)
            {
                await Remove(Identify, Class);
            }
        }
    }
}