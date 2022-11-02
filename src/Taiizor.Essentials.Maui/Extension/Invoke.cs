namespace Taiizor.Essentials.Maui.Extension
{
    public class Invoke
    {
        public static async Task ReferenceMethod(params object?[]? Arguments)
        {
            await Interop.Call("Taiizor.Invoke.ReferenceMethodAsync", Arguments);
        }

        public static async ValueTask<bool> ReferenceMethodBool(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallBool("Taiizor.Invoke.ReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<byte> ReferenceMethodByte(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallByte("Taiizor.Invoke.ReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<char> ReferenceMethodChar(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallChar("Taiizor.Invoke.ReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<long> ReferenceMethodLong(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallLong("Taiizor.Invoke.ReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<int> ReferenceMethodInteger(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("Taiizor.Invoke.ReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<string> ReferenceMethodString(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallString("Taiizor.Invoke.ReferenceMethodAsync", Arguments));
        }

        public static async ValueTask<object> ReferenceMethodObject(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallObject("Taiizor.Invoke.ReferenceMethodAsync", Arguments));
        }

        public static async Task AssemblyMethod(params object?[]? Arguments)
        {
            await Interop.Call("Taiizor.Invoke.MethodAsync", Arguments);
        }

        public static async ValueTask<bool> AssemblyMethodBool(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallBool("Taiizor.Invoke.MethodAsync", Arguments));
        }

        public static async ValueTask<byte> AssemblyMethodByte(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallByte("Taiizor.Invoke.MethodAsync", Arguments));
        }

        public static async ValueTask<char> AssemblyMethodChar(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallChar("Taiizor.Invoke.MethodAsync", Arguments));
        }

        public static async ValueTask<long> AssemblyMethodLong(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallLong("Taiizor.Invoke.MethodAsync", Arguments));
        }

        public static async ValueTask<int> AssemblyMethodInteger(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("Taiizor.Invoke.MethodAsync", Arguments));
        }

        public static async ValueTask<string> AssemblyMethodString(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallString("Taiizor.Invoke.MethodAsync", Arguments));
        }

        public static async ValueTask<object> AssemblyMethodObject(params object?[]? Arguments)
        {
            return await Task.FromResult(await Interop.CallObject("Taiizor.Invoke.MethodAsync", Arguments));
        }
    }
}