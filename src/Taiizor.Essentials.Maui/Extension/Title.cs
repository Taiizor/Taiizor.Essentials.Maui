namespace Taiizor.Essentials.Maui.Extension
{
    public class Title
    {
        public static async Task Set(string Title)
        {
            await Interop.Call("Taiizor.Title.Set", Title);
        }

        public static async ValueTask<string> Get()
        {
            return await Interop.CallString("Taiizor.Title.Get");
        }

        public static async ValueTask<bool> Check()
        {
            return await Interop.CallBool("Taiizor.Title.Check");
        }

        public static async ValueTask<bool> Check(string Title)
        {
            if (await Check() && await Get() == Title)
            {
                return true;
            }
            
            return false;
        }
    }
}