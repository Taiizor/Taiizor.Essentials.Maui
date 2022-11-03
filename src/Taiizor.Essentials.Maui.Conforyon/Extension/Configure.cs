using Taiizor.Essentials.Maui.Conforyon.Value;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public static class Configure
    {
        public static void UseConforyon(this MauiAppBuilder Builder)
        {
            Internal.ConforyonState = true;
        }
    }
}