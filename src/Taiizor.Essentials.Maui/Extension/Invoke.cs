using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Invoke
    {
        public static async Task ReferenceMethod(params object?[]? Arguments)
        {
            await Interop.Call("InvokeReferenceMethodAsync", Arguments);
        }

        public static async ValueTask<bool> ReferenceMethodBool(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallBool("InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<byte> ReferenceMethodByte(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallByte("InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<char> ReferenceMethodChar(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallChar("InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<long> ReferenceMethodLong(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallLong("InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<int> ReferenceMethodInteger(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<string> ReferenceMethodString(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallString("InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<object> ReferenceMethodObject(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallObject("InvokeReferenceMethodAsync", Arguments));
        }

        public static async Task AssemblyMethod(params object?[]? Arguments)
        {
            await Interop.Call("InvokeMethodAsync", Arguments);
        }

        public static async ValueTask<bool> AssemblyMethodBool(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallBool("InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<byte> AssemblyMethodByte(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallByte("InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<char> AssemblyMethodChar(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallChar("InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<long> AssemblyMethodLong(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallLong("InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<int> AssemblyMethodInteger(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("InvokeMethodAsync", Arguments));
        }
        
        public static async ValueTask<string> AssemblyMethodString(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallString("InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<object> AssemblyMethodObject(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallObject("InvokeMethodAsync", Arguments));
        }
    }
}