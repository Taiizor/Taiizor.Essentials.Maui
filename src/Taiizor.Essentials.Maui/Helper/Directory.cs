namespace Taiizor.Essentials.Maui.Helper
{
    internal class Directory
    {
        public static string GetDirectory => Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}