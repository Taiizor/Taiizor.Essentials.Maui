using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;
using HC = Taiizor.Essentials.Maui.Helper.Combine;
using HD = Taiizor.Essentials.Maui.Helper.Directory;
using HI = Taiizor.Essentials.Maui.Helper.Interop;
using SRA = System.Reflection.Assembly;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Interop
    {
        private static IJSRuntime JS = null;

        public Interop(IJSRuntime JSR)
        {
            _ = new Interop(JSR, Internal.JavascriptFiles, Internal.AssemblyLoad);
        }

        public Interop(IJSRuntime JSR, Dictionary<JavascriptEnum, bool> Files)
        {
            _ = new Interop(JSR, Files, Internal.AssemblyLoad);
        }

        public Interop(IJSRuntime JSR, Dictionary<JavascriptEnum, bool> Files, Dictionary<AssemblyEnum, bool> Assemblies)
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

            foreach (KeyValuePair<AssemblyEnum, bool> Assembly in Internal.AssemblyLoad)
            {
                if (Assemblies.ContainsKey(Assembly.Key) && Assemblies[Assembly.Key])
                {
                    try
                    {
                        string Path = HC.FullPath(HD.GetDirectory, $"Taiizor.Essentials.Maui.{Assembly.Key}", ".dll");

                        if (File.Exists(Path))
                        {
                            SRA.LoadFile(Path);
                        }
                    }
                    catch
                    {
                        //
                    }
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