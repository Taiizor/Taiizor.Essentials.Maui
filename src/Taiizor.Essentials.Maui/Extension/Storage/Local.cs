namespace Taiizor.Essentials.Maui.Extension.Storage
{
    public class Local
    {
        public static async Task Set(string Key, string Value)
        {
            await Interop.Call("Taiizor.Storage.Local.Set", Key, Value);
        }

        public static async ValueTask<string> Get(string Key)
        {
            return await Interop.CallString("Taiizor.Storage.Local.Get", Key);
        }

        public static async ValueTask<bool> Check(string Key)
        {
            return await Interop.CallBool("Taiizor.Storage.Local.Check", Key);
        }

        public static async ValueTask<bool> Check(string Key, string Value)
        {
            if (await Check(Key) && await Get(Key) == Value)
            {
                return true;
            }

            return false;
        }

        public static async Task Delete(string Key, bool Execute = false)
        {
            await Interop.Call("Taiizor.Storage.Local.Delete", Key, Execute);
        }
    }
}