namespace Taiizor.Essentials.Maui.Extension
{
    public class Redirect
    {
        public static async Task GoLocation()
        {
            await GoLocation("/");
        }

        public static async Task GoLocation(string Uri)
        {
            await Interop.Call("Taiizor.GoLocation", Uri);
        }
    }
}