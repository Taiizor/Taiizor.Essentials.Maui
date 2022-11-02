namespace Taiizor.Essentials.Maui.Extension.Storage
{
    public class Session
    {
        public static async Task Set(string Key, string Value)
        {
            await Interop.Call("Taiizor.Storage.Session.Set", Key, Value);
        }

        public static async ValueTask<string> Get(string Key)
        {
            return await Interop.CallString("Taiizor.Storage.Session.Get", Key);
        }

        public static async ValueTask<bool> Check(string Key)
        {
            return await Interop.CallBool("Taiizor.Storage.Session.Check", Key);
        }

        public static async Task Delete(string Key, bool Execute = false)
        {
            await Interop.Call("Taiizor.Storage.Session.Delete", Key, Execute);
        }
    }
}