namespace Taiizor.Essentials.Maui.Helper
{
    internal class Combine
    {
        public static string FullPath(string Directory, string File, string Extension)
        {
            return Path.Combine(Directory, $"{File}{Extension}");
        }
    }
}