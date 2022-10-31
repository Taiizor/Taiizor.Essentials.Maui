using System.Runtime.InteropServices;
using Taiizor.Essentials.Maui.AppCenter.Enum;

namespace Taiizor.Essentials.Maui.AppCenter.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WatchStruct
    {
        public string Name;
        public string Format;
        public string Prefix;
        public string Suffix;
        public WatchEnum Event;
        public WatchEnum Error;
        public string EventName;
        public string ErrorName;
        public string Properties;
        public string Attachments;
        public string PropertiesEvent;
        public string PropertiesError;
    }
}