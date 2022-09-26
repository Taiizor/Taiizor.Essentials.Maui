using System.Runtime.InteropServices;
using Taiizor.Essentials.Maui.AppCenter.Enum;

namespace Taiizor.Essentials.Maui.AppCenter.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WatchStruct
    {
        public string Format;
        public string Prefix;
        public string Suffix;
        public string Name;
        public WatchEnum Event;
        public WatchEnum Error;
    }
}