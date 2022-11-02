namespace Taiizor.Essentials.Maui.Extension
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
            await Interop.Call("Taiizor.Cookie.Set", Name, Value, Days, Path);
        }

        public static async ValueTask<string> Get(string Name)
        {
            return await Interop.CallString("Taiizor.Cookie.Get", Name);
        }

        public static async ValueTask<bool> Check(string Name)
        {
            return await Interop.CallBool("Taiizor.Cookie.Check", Name);
        }

        public static async Task Delete(string Name, bool Execute = false)
        {
            await Interop.Call("Taiizor.Cookie.Delete", Name, Execute);
        }
    }
}