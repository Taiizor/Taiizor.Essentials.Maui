namespace Taiizor.Essentials.Maui.Extension
{
    public class Lang
    {
        public static async Task SetTag(string Identify, string Language)
        {
            await Interop.Call("Taiizor.Lang.Tag.Set", Identify, Language);
        }

        public static async ValueTask<string> GetTag(string Identify)
        {
            return await Interop.CallString("Taiizor.Lang.Tag.Get", Identify);
        }

        public static async ValueTask<bool> CheckTag(string Identify)
        {
            return await Interop.CallBool("Taiizor.Lang.Tag.Check", Identify);
        }

        public static async Task SetHtml(string Language)
        {
            await Interop.Call("Taiizor.Lang.Html.Set", Language);
        }

        public static async ValueTask<string> GetHtml()
        {
            return await Interop.CallString("Taiizor.Lang.Html.Get");
        }

        public static async ValueTask<bool> CheckHtml()
        {
            return await Interop.CallBool("Taiizor.Lang.Html.Check");
        }

        public static async Task SetHead(string Language)
        {
            await Interop.Call("Taiizor.Lang.Head.Set", Language);
        }

        public static async ValueTask<string> GetHead()
        {
            return await Interop.CallString("Taiizor.Lang.Head.Get");
        }

        public static async ValueTask<bool> CheckHead()
        {
            return await Interop.CallBool("Taiizor.Lang.Head.Check");
        }

        public static async Task SetBody(string Language)
        {
            await Interop.Call("Taiizor.Lang.Body.Set", Language);
        }

        public static async ValueTask<string> GetBody()
        {
            return await Interop.CallString("Taiizor.Lang.Body.Get");
        }

        public static async ValueTask<bool> CheckBody()
        {
            return await Interop.CallBool("Taiizor.Lang.Body.Check");
        }
    }
}