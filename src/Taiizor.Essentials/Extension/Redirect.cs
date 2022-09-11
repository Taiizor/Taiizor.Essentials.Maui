namespace Taiizor.Essentials.Extension
{
    public class Redirect
    {
        public static async void GoLocation()
        {
            await GoLocation("/");
        }

        public static async Task GoLocation(string Uri)
        {
            await Interop.Call("GoLocation", Uri);
        }
    }
}