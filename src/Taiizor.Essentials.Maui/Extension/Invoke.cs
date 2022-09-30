namespace Taiizor.Essentials.Maui.Extension
{
    public class Invoke
    {
        public static async Task ReferenceMethod(params object?[]? Arguments)
        {
            await Interop.Call("Taiizor.InvokeReferenceMethodAsync", Arguments);
        }

        public static async ValueTask<bool> ReferenceMethodBool(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallBool("Taiizor.InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<byte> ReferenceMethodByte(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallByte("Taiizor.InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<char> ReferenceMethodChar(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallChar("Taiizor.InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<long> ReferenceMethodLong(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallLong("Taiizor.InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<int> ReferenceMethodInteger(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("Taiizor.InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<string> ReferenceMethodString(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallString("Taiizor.InvokeReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<object> ReferenceMethodObject(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallObject("Taiizor.InvokeReferenceMethodAsync", Arguments));
        }

        public static async Task AssemblyMethod(params object?[]? Arguments)
        {
            await Interop.Call("Taiizor.InvokeMethodAsync", Arguments);
        }

        public static async ValueTask<bool> AssemblyMethodBool(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallBool("Taiizor.InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<byte> AssemblyMethodByte(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallByte("Taiizor.InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<char> AssemblyMethodChar(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallChar("Taiizor.InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<long> AssemblyMethodLong(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallLong("Taiizor.InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<int> AssemblyMethodInteger(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("Taiizor.InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<string> AssemblyMethodString(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallString("Taiizor.InvokeMethodAsync", Arguments));
        }

        public static async ValueTask<object> AssemblyMethodObject(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallObject("Taiizor.InvokeMethodAsync", Arguments));
        }
    }
}