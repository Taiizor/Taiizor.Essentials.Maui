namespace Taiizor.Essentials.Maui.Extension
{
    public class Lang
    {
        public static async Task Set(string Identify, string Language)
        {
            await Interop.Call("SetLang", Identify, Language);
        }

        public static async ValueTask<string> Get(string Identify)
        {
            return await Interop.CallString("GetLang", Identify);
        }
        
        public static async ValueTask<bool> Check(string Identify)
        {
            return await Interop.CallBool("CheckLang", Identify);
        }

        public static async Task SetHtml(string Language)
        {
            await Interop.Call("SetLangHtml", Language);
        }

        public static async ValueTask<string> GetHtml()
        {
            return await Interop.CallString("GetLangHtml");
        }
        
        public static async Task SetBody(string Language)
        {
            await Interop.Call("SetLangBody", Language);
        }

        public static async ValueTask<string> GetBody()
        {
            return await Interop.CallString("GetLangBody");
        }
    }
}