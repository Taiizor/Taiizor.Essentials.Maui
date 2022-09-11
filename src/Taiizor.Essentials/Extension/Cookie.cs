using Microsoft.JSInterop;

namespace Taiizor.Essentials.Extension
{
    public class Cookie
    {
        public static async Task Set(string Name, string Value)
        {
            await Set(Name, Value, 1, "/");
        }

        public static async Task Set(string Name, string Value, int Days)
        {
            await Set(Name, Value, Days, "/");
        }

        public static async Task Set(string Name, string Value, int Days, string Path)
        {
            await Interop.Call("SetCookie", Name, Value, Days, Path);
        }

        public static async Task<string> Get(string Name)
        {
            return await Interop.CallString("GetCookie", Name);
        }

        public static async Task<bool> Check(string Name)
        {
            return await Interop.CallBool("CheckCookie", Name);
        }

        public static async Task Delete(string Name, bool Execute = false)
        {
            await Interop.Call("DeleteCookie", Name, Execute);
        }
    }
}