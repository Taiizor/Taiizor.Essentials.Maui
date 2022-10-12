namespace Taiizor.Essentials.Maui.Extension
{
    public class Location
    {
        public static async ValueTask<string> GetHref()
        {
            return await Interop.CallString("Taiizor.GetHref");
        }

        public static async ValueTask<string> GetHost()
        {
            return await Interop.CallString("Taiizor.GetHost");
        }

        public static async ValueTask<string> GetPort()
        {
            return await Interop.CallString("Taiizor.GetPort");
        }

        public static async ValueTask<string> GetHash()
        {
            return await Interop.CallString("Taiizor.GetHash");
        }

        public static async ValueTask<string> GetOrigin()
        {
            return await Interop.CallString("Taiizor.GetOrigin");
        }

        public static async ValueTask<string> GetSearch()
        {
            return await Interop.CallString("Taiizor.GetSearch");
        }

        public static async ValueTask<string> GetProtocol()
        {
            return await Interop.CallString("Taiizor.GetProtocol");
        }

        public static async ValueTask<string> GetHostname()
        {
            return await Interop.CallString("Taiizor.GetHostname");
        }

        public static async ValueTask<string> GetPathname()
        {
            return await Interop.CallString("Taiizor.GetPathname");
        }
    }
}