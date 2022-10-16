using Microsoft.JSInterop;
using CCHEX = Conforyon.Color.HEX;
using CCRGB = Conforyon.Color.RGB;
using Conforyon.Enum;
using HC = Taiizor.Essentials.Maui.Conforyon.Helper.Converter;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Color
    {
        public class Hex
        {
            [JSInvokable("ColorHexRgbObject")]
            //[JSInvokableAttribute("ColorHexRgbObject")]
            public static string RgbObject(object Hex, string Type = "RGB1", string Error = "Error!")
            {
                return CCHEX.RGB(Hex, HC.Convert(Type, Enums.ColorType.RGB1), Error);
            }
            
            [JSInvokable("ColorHexRgbText")]
            //[JSInvokableAttribute("ColorHexRgbText")]
            public static string RgbText(string Hex, string Type = "RGB1", string Error = "Error!")
            {
                return CCHEX.RGB(Hex, HC.Convert(Type, Enums.ColorType.RGB1), Error);
            }
        }

        public class Rgb
        {
            [JSInvokable("ColorRgbHexLong")]
            //[JSInvokableAttribute("ColorRgbHexLong")]
            public static string HexLong(long R, long G, long B, bool Sharp = false, string Error = "Error!")
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }
            
            [JSInvokable("ColorRgbHexObject")]
            //[JSInvokableAttribute("ColorRgbHexObject")]
            public static string HexObject(object R, object G, object B, bool Sharp = false, string Error = "Error!")
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }

            [JSInvokable("ColorRgbHexText")]
            //[JSInvokableAttribute("ColorRgbHexText")]
            public static string HexText(string R, string G, string B, bool Sharp = false, string Error = "Error!")
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }

            [JSInvokable("ColorRgbHexInteger")]
            //[JSInvokableAttribute("ColorRgbHexInteger")]
            public static string HexInteger(int R, int G, int B, bool Sharp = false, string Error = "Error!")
            {
                return CCRGB.HEX(R, G, B, Sharp, Error);
            }
        }
    }
}