using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CCHEX = Conforyon.Color.HEX;
using CCRGB = Conforyon.Color.RGB;
using HC = Taiizor.Essentials.Maui.Conforyon.Helper.Converter;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Color
    {
        public class Hex
        {
            [JSInvokable("ColorHexRgbObject")]
            //[JSInvokableAttribute("ColorHexRgbObject")]
            public static string RgbObject(object Hex, string Type = Internal.ColorType, string Error = Internal.Error)
            {
                return CCHEX.RGB(Hex, HC.Convert(Type, Internal.ColorEnumType), Error);
            }

            [JSInvokable("ColorHexRgbText")]
            //[JSInvokableAttribute("ColorHexRgbText")]
            public static string RgbText(string Hex, string Type = Internal.ColorType, string Error = Internal.Error)
            {
                return CCHEX.RGB(Hex, HC.Convert(Type, Internal.ColorEnumType), Error);
            }
        }

        public class Rgb
        {
            [JSInvokable("ColorRgbHexLong")]
            //[JSInvokableAttribute("ColorRgbHexLong")]
            public static string HexLong(long R, long G, long B, bool Sharp = Internal.ColorSharp, string Error = Internal.Error)
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }

            [JSInvokable("ColorRgbHexObject")]
            //[JSInvokableAttribute("ColorRgbHexObject")]
            public static string HexObject(object R, object G, object B, bool Sharp = Internal.ColorSharp, string Error = Internal.Error)
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }

            [JSInvokable("ColorRgbHexText")]
            //[JSInvokableAttribute("ColorRgbHexText")]
            public static string HexText(string R, string G, string B, bool Sharp = Internal.ColorSharp, string Error = Internal.Error)
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }

            [JSInvokable("ColorRgbHexInteger")]
            //[JSInvokableAttribute("ColorRgbHexInteger")]
            public static string HexInteger(int R, int G, int B, bool Sharp = Internal.ColorSharp, string Error = Internal.Error)
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }
        }
    }
}