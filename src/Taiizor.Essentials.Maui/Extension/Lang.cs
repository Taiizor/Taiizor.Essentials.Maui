namespace Taiizor.Essentials.Maui.Extension
{
    public class Lang
    {
        public static async Task Set(string Identify, string Language)
        {
            await Interop.Call("Taiizor.SetLang", Identify, Language);
        }

        public static async ValueTask<string> Get(string Identify)
        {
            return await Interop.CallString("Taiizor.GetLang", Identify);
        }

        public static async ValueTask<bool> Check(string Identify)
        {
            return await Interop.CallBool("Taiizor.CheckLang", Identify);
        }

        public static async Task SetHtml(string Language)
        {
            await Interop.Call("Taiizor.SetLangHtml", Language);
        }

        public static async ValueTask<string> GetHtml()
        {
            return await Interop.CallString("Taiizor.GetLangHtml");
        }

        public static async Task SetHead(string Language)
        {
            await Interop.Call("Taiizor.SetLangHead", Language);
        }

        public static async ValueTask<string> GetHead()
        {
            return await Interop.CallString("Taiizor.GetLangHead");
        }

        public static async Task SetBody(string Language)
        {
            await Interop.Call("Taiizor.SetLangBody", Language);
        }

        public static async ValueTask<string> GetBody()
        {
            return await Interop.CallString("Taiizor.GetLangBody");
        }
    }
}