namespace Taiizor.Essentials.Maui.Extension
{
    public class Add
    {
        public static async Task Head(string Tag)
        {
            await Interop.Call("Taiizor.HeadAdd", Tag);
        }

        public static async Task HeadScript(string Node)
        {
            await Interop.Call("Taiizor.HeadScriptAdd", Node);
        }

        public static async Task Body(string Tag)
        {
            await Interop.Call("Taiizor.BodyAdd", Tag);
        }

        public static async Task BodyScript(string Node)
        {
            await Interop.Call("Taiizor.BodyScriptAdd", Node);
        }
    }
}