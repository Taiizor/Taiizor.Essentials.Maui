namespace Taiizor.Essentials.Maui.Extension
{
    public class Add
    {
        public static async Task Head(string Tag)
        {
            await Interop.Call("Taiizor.Add.Head", Tag);
        }

        public static async Task HeadScript(string Node)
        {
            await Interop.Call("Taiizor.Add.Script.Head", Node);
        }

        public static async Task Body(string Tag)
        {
            await Interop.Call("Taiizor.Add.Body", Tag);
        }

        public static async Task BodyScript(string Node)
        {
            await Interop.Call("Taiizor.Add.Script.Body", Node);
        }
    }
}