namespace Taiizor.Essentials.Maui.Extension
{
    public class Attribute
    {
        public static async Task Set(string Identify, string Name)
        {
            await Set(Identify, Name, "");
        }

        public static async Task Set(string Identify, string Name, string Value)
        {
            await Interop.Call("Taiizor.SetAttribute", Identify, Name, Value);
        }

        public static async Task Remove(string Identify, string Name)
        {
            await Interop.Call("Taiizor.RemoveAttribute", Identify, Name);
        }
    }
}