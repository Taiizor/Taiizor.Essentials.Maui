using Microsoft.JSInterop;

namespace Taiizor.Essentials.Extension
{
    public class Add
    {
        public static async Task Head(string Tag)
        {
            await Interop.JS.InvokeVoidAsync("HeadAdd", Tag);
        }

        public static async Task HeadScript(string Node)
        {
            await Interop.JS.InvokeVoidAsync("HeadScriptAdd", Node);
        }

        public static async Task Body(string Tag)
        {
            await Interop.JS.InvokeVoidAsync("BodyAdd", Tag);
        }

        public static async Task BodyScript(string Node)
        {
            await Interop.JS.InvokeVoidAsync("BodyScriptAdd", Node);
        }
    }
}