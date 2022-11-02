namespace Taiizor.Essentials.Maui.Extension
{
    public class Location
    {
        public static async Task SetHref(string Href)
        {
            await Interop.Call("Taiizor.Location.Href.Set", Href);
        }

        public static async ValueTask<string> GetHref()
        {
            return await Interop.CallString("Taiizor.Location.Href.Get");
        }

        public static async Task SetHost(string Host)
        {
            await Interop.Call("Taiizor.Location.Host.Set", Host);
        }

        public static async ValueTask<string> GetHost()
        {
            return await Interop.CallString("Taiizor.Location.Host.Get");
        }

        public static async Task SetPort(string Port)
        {
            await Interop.Call("Taiizor.Location.Port.Set", Port);
        }

        public static async ValueTask<string> GetPort()
        {
            return await Interop.CallString("Taiizor.Location.Port.Get");
        }

        public static async Task SetHash(string Hash)
        {
            await Interop.Call("Taiizor.Location.Hash.Set", Hash);
        }

        public static async ValueTask<string> GetHash()
        {
            return await Interop.CallString("Taiizor.Location.Hash.Get");
        }

        public static async Task SetOrigin(string Origin)
        {
            await Interop.Call("Taiizor.Location.Origin.Set", Origin);
        }

        public static async ValueTask<string> GetOrigin()
        {
            return await Interop.CallString("Taiizor.Location.Origin.Get");
        }

        public static async Task SetSearch(string Search)
        {
            await Interop.Call("Taiizor.Location.Search.Set", Search);
        }

        public static async ValueTask<string> GetSearch()
        {
            return await Interop.CallString("Taiizor.Location.Search.Get");
        }

        public static async Task SetProtocol(string Protocol)
        {
            await Interop.Call("Taiizor.Location.Protocol.Set", Protocol);
        }

        public static async ValueTask<string> GetProtocol()
        {
            return await Interop.CallString("Taiizor.Location.Protocol.Get");
        }

        public static async Task SetHostname(string Hostname)
        {
            await Interop.Call("Taiizor.Location.Hostname.Set", Hostname);
        }

        public static async ValueTask<string> GetHostname()
        {
            return await Interop.CallString("Taiizor.Location.Hostname.Get");
        }

        public static async Task SetPathname(string Pathname)
        {
            await Interop.Call("Taiizor.Location.Pathname.Set", Pathname);
        }

        public static async ValueTask<string> GetPathname()
        {
            return await Interop.CallString("Taiizor.Location.Pathname.Get");
        }
    }
}