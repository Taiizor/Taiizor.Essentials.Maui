namespace Taiizor.Essentials.Maui.Extension.Storage
{
    public class Local
    {
        public static async Task Set(string Key, string Value)
        {
            await Interop.Call("SetLocalStorage", Key, Value);
        }

        public static async ValueTask<string> Get(string Key)
        {
            return await Interop.CallString("GetLocalStorage", Key);
        }

        public static async ValueTask<bool> Check(string Key)
        {
            return await Interop.CallBool("CheckLocalStorage", Key);
        }

        public static async Task Delete(string Key, bool Execute = false)
        {
            await Interop.Call("DeleteLocalStorage", Key, Execute);
        }
    }
}