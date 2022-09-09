using Microsoft.JSInterop;
using HI = Taiizor.Essentials.Helper.Interop;

namespace Taiizor.Essentials.Extension
{
    public class Interop
    {
        public static IJSRuntime JS;

        public Interop(IJSRuntime JSR, string TaiizorBlazorScript)
        {
            HI.CheckRuntime(JSR);
            HI.CheckScript(TaiizorBlazorScript);

            JS = JSR;
            
            JS.InvokeVoidAsync("eval", TaiizorBlazorScript);
        }

        public static async Task Call(string Function)
        {
            await JS.InvokeVoidAsync(Function);
        }

        public static async Task Call(string Function, int Argument)
        {
            await JS.InvokeVoidAsync(Function, Argument);
        }

        public static async Task Call(string Function, bool Argument)
        {
            await JS.InvokeVoidAsync(Function, Argument);
        }

        public static async Task Call(string Function, string Argument)
        {
            await JS.InvokeVoidAsync(Function, Argument);
        }

        public static async Task Call(string Function, object Argument)
        {
            await JS.InvokeVoidAsync(Function, Argument);
        }

        public static async Task Call(string Function, params int[] Arguments)
        {
            await JS.InvokeVoidAsync(Function, Arguments);
        }

        public static async Task Call(string Function, params bool[] Arguments)
        {
            await JS.InvokeVoidAsync(Function, Arguments);
        }

        public static async Task Call(string Function, params string[] Arguments)
        {
            await JS.InvokeVoidAsync(Function, Arguments);
        }

        public static async Task Call(string Function, params object[] Arguments)
        {
            await JS.InvokeVoidAsync(Function, Arguments);
        }

        public static async Task<string> CallString(string Function)
        {
            return await JS.InvokeAsync<string>(Function);
        }

        public static async Task<string> CallString(string Function, int Argument)
        {
            return await JS.InvokeAsync<string>(Function, Argument);
        }

        public static async Task<string> CallString(string Function, bool Argument)
        {
            return await JS.InvokeAsync<string>(Function, Argument);
        }

        public static async Task<string> CallString(string Function, string Argument)
        {
            return await JS.InvokeAsync<string>(Function, Argument);
        }

        public static async Task<string> CallString(string Function, object Argument)
        {
            return await JS.InvokeAsync<string>(Function, Argument);
        }

        public static async Task<string> CallString(string Function, params int[] Arguments)
        {
            return await JS.InvokeAsync<string>(Function, Arguments);
        }

        public static async Task<string> CallString(string Function, params bool[] Arguments)
        {
            return await JS.InvokeAsync<string>(Function, Arguments);
        }

        public static async Task<string> CallString(string Function, params string[] Arguments)
        {
            return await JS.InvokeAsync<string>(Function, Arguments);
        }

        public static async Task<string> CallString(string Function, params object[] Arguments)
        {
            return await JS.InvokeAsync<string>(Function, Arguments);
        }

        public static async Task<int> CallInteger(string Function)
        {
            return await JS.InvokeAsync<int>(Function);
        }

        public static async Task<int> CallInteger(string Function, int Argument)
        {
            return await JS.InvokeAsync<int>(Function, Argument);
        }

        public static async Task<int> CallInteger(string Function, bool Argument)
        {
            return await JS.InvokeAsync<int>(Function, Argument);
        }

        public static async Task<int> CallInteger(string Function, string Argument)
        {
            return await JS.InvokeAsync<int>(Function, Argument);
        }

        public static async Task<int> CallInteger(string Function, object Argument)
        {
            return await JS.InvokeAsync<int>(Function, Argument);
        }

        public static async Task<int> CallInteger(string Function, params int[] Arguments)
        {
            return await JS.InvokeAsync<int>(Function, Arguments);
        }

        public static async Task<int> CallInteger(string Function, params bool[] Arguments)
        {
            return await JS.InvokeAsync<int>(Function, Arguments);
        }

        public static async Task<int> CallInteger(string Function, params string[] Arguments)
        {
            return await JS.InvokeAsync<int>(Function, Arguments);
        }

        public static async Task<int> CallInteger(string Function, params object[] Arguments)
        {
            return await JS.InvokeAsync<int>(Function, Arguments);
        }
    }
}