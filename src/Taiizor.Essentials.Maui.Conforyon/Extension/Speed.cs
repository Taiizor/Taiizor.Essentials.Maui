using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CSKPH = Conforyon.Speed.KPH;
using CSMPH = Conforyon.Speed.MPH;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Speed
    {
        public class Kph
        {
            public class Mph
            {
                [JSInvokable("SpeedKphMphConvertInteger")]
                //[JSInvokableAttribute("SpeedKphMphConvertInteger")]
                public static string ConvertInteger(int Kilometers, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSKPH.MPH(Kilometers, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("SpeedKphMphConvertLong")]
                //[JSInvokableAttribute("SpeedKphMphConvertLong")]
                public static string ConvertLong(long Kilometers, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSKPH.MPH(Kilometers, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("SpeedKphMphConvertObject")]
                //[JSInvokableAttribute("SpeedKphMphConvertObject")]
                public static string ConvertObject(object Kilometers, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSKPH.MPH(Kilometers, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("SpeedKphMphConvertText")]
                //[JSInvokableAttribute("SpeedKphMphConvertText")]
                public static string ConvertText(string Kilometers, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSKPH.MPH(Kilometers, Decimal, Comma, PostComma, Text, Error);
                }
            }
        }

        public class Mph
        {
            public class Kph
            {
                [JSInvokable("SpeedMphKphConvertInteger")]
                //[JSInvokableAttribute("SpeedMphKphConvertInteger")]
                public static string ConvertInteger(int Miles, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSMPH.KPH(Miles, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("SpeedMphKphConvertLong")]
                //[JSInvokableAttribute("SpeedMphKphConvertLong")]
                public static string ConvertLong(long Miles, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSMPH.KPH(Miles, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("SpeedMphKphConvertObject")]
                //[JSInvokableAttribute("SpeedMphKphConvertObject")]
                public static string ConvertObject(object Miles, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSMPH.KPH(Miles, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("SpeedMphKphConvertText")]
                //[JSInvokableAttribute("SpeedMphKphConvertText")]
                public static string ConvertText(string Miles, bool Decimal, bool Comma, int PostComma = Internal.SpeedPostComma, bool Text = Internal.SpeedText, string Error = Internal.Error)
                {
                    return CSMPH.KPH(Miles, Decimal, Comma, PostComma, Text, Error);
                }
            }
        }
    }
}