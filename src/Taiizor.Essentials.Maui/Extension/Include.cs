namespace Taiizor.Essentials.Maui.Extension
{
    public class Include
    {
        public static async Task Font(string Path)
        {
            await Font(Path, "stylesheet");
        }

        public static async Task FontProtected(string Path, string Pathname)
        {
            await FontProtected(Path, "stylesheet", Pathname);
        }

        public static async Task Font(string Path, string Rel)
        {
            await Interop.Call("Taiizor.Include.Font", Path, Rel);
        }

        public static async Task FontProtected(string Path, string Rel, string Pathname)
        {
            if (await Location.GetPathname() == Pathname)
            {
                await Font(Path, Rel);
            }
        }

        public static async Task Script(string Path)
        {
            await Interop.Call("Taiizor.Include.Js", Path);
        }
        
        public static async Task ScriptProtected(string Path, string Pathname)
        {
            if (await Location.GetPathname() == Pathname)
            {
                await Script(Path);
            }
        }

        public static async Task Stylesheet(string Path)
        {
            await Stylesheet(Path, "stylesheet");
        }

        public static async Task StylesheetProtected(string Path, string Pathname)
        {
            await StylesheetProtected(Path, "stylesheet", Pathname);
        }

        public static async Task Stylesheet(string Path, string Rel)
        {
            await Stylesheet(Path, Rel, "text/css");
        }

        public static async Task StylesheetProtected(string Path, string Rel, string Pathname)
        {
            await StylesheetProtected(Path, Rel, "text/css", Pathname);
        }

        public static async Task Stylesheet(string Path, string Rel, string Type)
        {
            await Interop.Call("Taiizor.Include.Css", Path, Rel, Type);
        }

        public static async Task StylesheetProtected(string Path, string Rel, string Type, string Pathname)
        {
            if (await Location.GetPathname() == Pathname)
            {
                await Stylesheet(Path, Rel, Type);
            }
        }
    }
}