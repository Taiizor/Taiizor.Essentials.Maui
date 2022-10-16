using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;
using HI = Taiizor.Essentials.Maui.Helper.Interop;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Interop
    {
        private static IJSRuntime JS = null;

        public Interop(IJSRuntime JSR)
        {
            _ = new Interop(JSR, Internal.JavascriptFiles);
        }

        public Interop(IJSRuntime JSR, Dictionary<JavascriptEnum, bool> Files)
        {
            HI.CheckRuntime(JSR);
            
            JS = JSR;

            foreach (KeyValuePair<JavascriptEnum, bool> File in Internal.JavascriptFiles)
            {
                if (!Files.ContainsKey(File.Key) || Files[File.Key])
                {
                    _ = Call("eval", Javascript.File(File.Key));
                }
            }
        }

        public static async Task Call(string Function, params object?[]? Arguments)
        {
            await JS.InvokeVoidAsync(Function, Arguments);
        }

        public static async ValueTask<bool> CallBool(string Function, params object?[]? Arguments)
        {
            return await JS.InvokeAsync<bool>(Function, Arguments);
        }

        public static async ValueTask<byte> CallByte(string Function, params object?[]? Arguments)
        {
            return await JS.InvokeAsync<byte>(Function, Arguments);
        }

        public static async ValueTask<char> CallChar(string Function, params object?[]? Arguments)
        {
            return await JS.InvokeAsync<char>(Function, Arguments);
        }

        public static async ValueTask<long> CallLong(string Function, params object?[]? Arguments)
        {
            return await JS.InvokeAsync<long>(Function, Arguments);
        }

        public static async ValueTask<int> CallInteger(string Function, params object?[]? Arguments)
        {
            return await JS.InvokeAsync<int>(Function, Arguments);
        }

        public static async ValueTask<string> CallString(string Function, params object?[]? Arguments)
        {
            return await JS.InvokeAsync<string>(Function, Arguments);
        }

        public static async ValueTask<object> CallObject(string Function, params object?[]? Arguments)
        {
            return await JS.InvokeAsync<object>(Function, Arguments);
        }
    }
}