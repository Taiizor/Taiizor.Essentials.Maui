namespace Taiizor.Essentials.Maui.Extension
{
    public class Redirect
    {
        public static async Task Location()
        {
            await Location("/");
        }

        public static async Task Location(string Uri)
        {
            await Interop.Call("Taiizor.Redirect.Location", Uri);
        }
    }
}