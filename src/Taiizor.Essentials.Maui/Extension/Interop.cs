using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Interop
    {
        public static IJSRuntime JS;

        public Interop(IJSRuntime JSR)
        {
            JS = JSR;
        }

        public static async ValueTask<string> CallString(string Function)
        {
            return await JS.InvokeAsync<string>(Function);
        }

        public static async ValueTask<string> CallString(string Function, string Argument)
        {
            return await JS.InvokeAsync<string>(Function, Argument);
        }

        public static async ValueTask<string> CallString(string Function, int Argument)
        {
            return await JS.InvokeAsync<string>(Function, Argument);
        }

        public static async ValueTask<string> CallString(string Function, params string[] Arguments)
        {
            return await JS.InvokeAsync<string>(Function, Arguments);
        }

        public static async ValueTask<int> CallInteger(string Function)
        {
            return await JS.InvokeAsync<int>(Function);
        }

        public static async ValueTask<int> CallInteger(string Function, int Argument)
        {
            return await JS.InvokeAsync<int>(Function, Argument);
        }

        public static async ValueTask<int> CallInteger(string Function, string Argument)
        {
            return await JS.InvokeAsync<int>(Function, Argument);
        }

        public static async ValueTask<int> CallInt(string Function, params string[] Arguments)
        {
            return await JS.InvokeAsync<int>(Function, Arguments);
        }
    }
}