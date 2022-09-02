namespace Taiizor.Essentials.Maui.Extension
{
    public class Invoke
    {
        public static async Task Method(string Assembly, string Method, params int[] Arguments)
        {
            await Interop.Call("InvokeMethodAsync", Assembly, Method, Arguments);
        }

        public static async Task Method(string Assembly, string Method, params bool[] Arguments)
        {
            await Interop.Call("InvokeMethodAsync", Assembly, Method, Arguments);
        }

        public static async Task Method(string Assembly, string Method, params string[] Arguments)
        {
            await Interop.Call("InvokeMethodAsync", Assembly, Method, Arguments);
        }

        public static async Task Method(string Assembly, string Method, params object[] Arguments)
        {
            await Interop.Call("InvokeMethodAsync", Assembly, Method, Arguments);
        }

        public static async Task Method(params object[] Arguments)
        {
            await Interop.Call("InvokeReferenceMethodAsync", Arguments);
        }

        public static async Task<string> MethodString(string Assembly, string Method, params int[] Arguments)
        {
            return await Task.FromResult(await Interop.CallString("InvokeMethodAsync", Assembly, Method, Arguments));
        }

        public static async Task<string> MethodString(string Assembly, string Method, params bool[] Arguments)
        {
            return await Task.FromResult(await Interop.CallString("InvokeMethodAsync", Assembly, Method, Arguments));
        }

        public static async Task<string> MethodString(string Assembly, string Method, params string[] Arguments)
        {
            return await Task.FromResult(await Interop.CallString("InvokeMethodAsync", Assembly, Method, Arguments));
        }

        public static async Task<string> MethodString(string Assembly, string Method, params object[] Arguments)
        {
            return await Task.FromResult(await Interop.CallString("InvokeMethodAsync", Assembly, Method, Arguments));
        }

        public static async Task<int> MethodInteger(string Assembly, string Method, params int[] Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("InvokeMethodAsync", Assembly, Method, Arguments));
        }

        public static async Task<int> MethodInteger(string Assembly, string Method, params bool[] Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("InvokeMethodAsync", Assembly, Method, Arguments));
        }

        public static async Task<int> MethodInteger(string Assembly, string Method, params string[] Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("InvokeMethodAsync", Assembly, Method, Arguments));
        }

        public static async Task<int> MethodInteger(string Assembly, string Method, params object[] Arguments)
        {
            return await Task.FromResult(await Interop.CallInteger("InvokeMethodAsync", Assembly, Method, Arguments));
        }
    }
}