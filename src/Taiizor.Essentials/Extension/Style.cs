namespace Taiizor.Essentials.Extension
{
    public class Style
    {
        public static async Task Add(string Identify, string Style, string Value)
        {
            await Interop.Call("AddStyle", Identify, Style, Value);
        }

        public static async Task Add(string Identify, params KeyValuePair<string, string>[] Styles)
        {
            foreach (KeyValuePair<string, string> Style in Styles)
            {
                await Add(Identify, Style.Key, Style.Value);
            }
        }

        public static async Task Set(string Identify, string Style)
        {
            await Interop.Call("SetStyle", Identify, Style);
        }

        public static async Task Toggle(string Identify)
        {
            await Interop.Call("ToggleStyle", Identify);
        }

        public static async Task Remove(string Identify, string Style)
        {
            await Interop.Call("RemoveStyle", Identify, Style);
        }

        public static async Task Remove(string Identify, params string[] Styles)
        {
            foreach (string Style in Styles)
            {
                await Remove(Identify, Style);
            }
        }
    }
}