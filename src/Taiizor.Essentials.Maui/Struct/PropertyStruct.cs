using System.Runtime.InteropServices;

namespace Taiizor.Essentials.Maui.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PropertyStruct
    {
        public bool Resizable;
        public bool Minimizable;
        public bool Maximizable;
        public bool AlwaysOnTop;
        public MovanizeStruct? MoveAndResize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MovanizeStruct
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
    }
}