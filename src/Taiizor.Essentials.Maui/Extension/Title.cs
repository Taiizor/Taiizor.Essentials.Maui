namespace Taiizor.Essentials.Maui.Extension
{
    public class Title
    {
        public static async Task Set(string Title)
        {
            await Interop.Call("Taiizor.SetTitle", Title);
        }

        public static async ValueTask<string> Get()
        {
            return await Interop.CallString("Taiizor.GetTitle");
        }

        public static async ValueTask<bool> Check()
        {
            return await Interop.CallBool("Taiizor.CheckTitle");
        }
    }
}