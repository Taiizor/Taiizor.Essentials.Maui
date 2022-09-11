namespace Taiizor.Essentials.Extension
{
    public class Add
    {
        public static async Task Head(string Tag)
        {
            await Interop.Call("HeadAdd", Tag);
        }

        public static async Task HeadScript(string Node)
        {
            await Interop.Call("HeadScriptAdd", Node);
        }

        public static async Task Body(string Tag)
        {
            await Interop.Call("BodyAdd", Tag);
        }

        public static async Task BodyScript(string Node)
        {
            await Interop.Call("BodyScriptAdd", Node);
        }
    }
}