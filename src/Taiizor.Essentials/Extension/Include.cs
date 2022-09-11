namespace Taiizor.Essentials.Extension
{
    public class Include
    {
        public static async Task Font(string Path)
        {
            await Font(Path, "stylesheet");
        }

        public static async Task Font(string Path, string Rel)
        {
            await Interop.Call("IncludeFont", Path, Rel);
        }

        public static async Task Script(string Path)
        {
            await Interop.Call("IncludeJs", Path);
        }

        public static async Task Stylesheet(string Path)
        {
            await Stylesheet(Path, "stylesheet");
        }

        public static async Task Stylesheet(string Path, string Rel)
        {
            await Stylesheet(Path, Rel, "text/css");
        }

        public static async Task Stylesheet(string Path, string Rel, string Type)
        {
            await Interop.Call("IncludeCss", Path, Rel, Type);
        }
    }
}