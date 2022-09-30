namespace Taiizor.Essentials.Maui.Extension
{
    public class Title
    {
        public static async Task Set(string Title)
        {
            await Interop.Call("SetTitle", Title);
        }

        public static async ValueTask<string> Get()
        {
            return await Interop.CallString("GetTitle");
        }

        public static async ValueTask<bool> Check()
        {
            return await Interop.CallBool("CheckTitle");
        }
    }
}