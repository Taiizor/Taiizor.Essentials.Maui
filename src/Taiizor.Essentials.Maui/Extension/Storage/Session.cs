namespace Taiizor.Essentials.Maui.Extension.Storage
{
    public class Session
    {
        public static async Task Set(string Key, string Value)
        {
            await Interop.Call("SetSessionStorage", Key, Value);
        }

        public static async ValueTask<string> Get(string Key)
        {
            return await Interop.CallString("GetSessionStorage", Key);
        }

        public static async ValueTask<bool> Check(string Key)
        {
            return await Interop.CallBool("CheckSessionStorage", Key);
        }

        public static async Task Delete(string Key, bool Execute = false)
        {
            await Interop.Call("DeleteSessionStorage", Key, Execute);
        }
    }
}