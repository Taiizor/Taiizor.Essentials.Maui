namespace Taiizor.Essentials.Maui.Extension
{
    public class Reload
    {
        public static async Task Page()
        {
            await Page(true);
        }

        public static async Task Page(bool Redirect)
        {
            if (Redirect)
            {
                await Interop.Call("Reload");
            }
        }

        public static async Task Element(string Identify)
        {
            await Element(Identify, true);
        }

        public static async Task Element(string Identify, bool Method)
        {
            await Interop.Call("ReloadElement", Identify, Method);
        }
    }
}