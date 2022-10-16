using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CTCM = Conforyon.Typology.CM;
using CTINCH = Conforyon.Typology.INCH;
using CTPX = Conforyon.Typology.PX;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Typology
    {
        public class Cm
        {
            public class Px
            {
                [JSInvokable("TypologyCmPxConvertInteger")]
                //[JSInvokableAttribute("TypologyCmPxConvertInteger")]
                public static string ConvertInteger(int Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.PX(Centimeter, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyCmPxConvertLong")]
                //[JSInvokableAttribute("TypologyCmPxConvertLong")]
                public static string ConvertLong(long Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.PX(Centimeter, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyCmPxConvertObject")]
                //[JSInvokableAttribute("TypologyCmPxConvertObject")]
                public static string ConvertObject(object Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.PX(Centimeter, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyCmPxConvertText")]
                //[JSInvokableAttribute("TypologyCmPxConvertText")]
                public static string ConvertText(string Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.PX(Centimeter, Decimal, Comma, PostComma, Error);
                }
            }

            public class Inch
            {
                [JSInvokable("TypologyCmInchConvertInteger")]
                //[JSInvokableAttribute("TypologyCmInchConvertInteger")]
                public static string ConvertInteger(int Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.INCH(Centimeter, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyCmInchConvertLong")]
                //[JSInvokableAttribute("TypologyCmInchConvertLong")]
                public static string ConvertLong(long Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.INCH(Centimeter, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyCmInchConvertObject")]
                //[JSInvokableAttribute("TypologyCmInchConvertObject")]
                public static string ConvertObject(object Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.INCH(Centimeter, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyCmInchConvertText")]
                //[JSInvokableAttribute("TypologyCmInchConvertText")]
                public static string ConvertText(string Centimeter, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTCM.INCH(Centimeter, Decimal, Comma, PostComma, Error);
                }
            }
        }

        public class Px
        {
            public class Cm
            {
                [JSInvokable("TypologyPxCmConvertInteger")]
                //[JSInvokableAttribute("TypologyPxCmConvertInteger")]
                public static string ConvertInteger(int Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.CM(Pixel, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyPxCmConvertLong")]
                //[JSInvokableAttribute("TypologyPxCmConvertLong")]
                public static string ConvertLong(long Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.CM(Pixel, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyPxCmConvertObject")]
                //[JSInvokableAttribute("TypologyPxCmConvertObject")]
                public static string ConvertObject(object Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.CM(Pixel, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyPxCmConvertText")]
                //[JSInvokableAttribute("TypologyPxCmConvertText")]
                public static string ConvertText(string Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.CM(Pixel, Decimal, Comma, PostComma, Error);
                }
            }

            public class Inch
            {
                [JSInvokable("TypologyPxInchConvertInteger")]
                //[JSInvokableAttribute("TypologyPxInchConvertInteger")]
                public static string ConvertInteger(int Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.INCH(Pixel, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyPxInchConvertLong")]
                //[JSInvokableAttribute("TypologyPxInchConvertLong")]
                public static string ConvertLong(long Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.INCH(Pixel, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyPxInchConvertObject")]
                //[JSInvokableAttribute("TypologyPxInchConvertObject")]
                public static string ConvertObject(object Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.INCH(Pixel, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyPxInchConvertText")]
                //[JSInvokableAttribute("TypologyPxInchConvertText")]
                public static string ConvertText(string Pixel, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTPX.INCH(Pixel, Decimal, Comma, PostComma, Error);
                }
            }
        }

        public class Inch
        {
            public class Cm
            {
                [JSInvokable("TypologyInchCmConvertInteger")]
                //[JSInvokableAttribute("TypologyInchCmConvertInteger")]
                public static string ConvertInteger(int Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.CM(Inch, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyInchCmConvertLong")]
                //[JSInvokableAttribute("TypologyInchCmConvertLong")]
                public static string ConvertLong(long Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.CM(Inch, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyInchCmConvertObject")]
                //[JSInvokableAttribute("TypologyInchCmConvertObject")]
                public static string ConvertObject(object Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.CM(Inch, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyInchCmConvertText")]
                //[JSInvokableAttribute("TypologyInchCmConvertText")]
                public static string ConvertText(string Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.CM(Inch, Decimal, Comma, PostComma, Error);
                }
            }

            public class Px
            {
                [JSInvokable("TypologyInchPxConvertInteger")]
                //[JSInvokableAttribute("TypologyInchPxConvertInteger")]
                public static string ConvertInteger(int Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.PX(Inch, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyInchPxConvertLong")]
                //[JSInvokableAttribute("TypologyInchPxConvertLong")]
                public static string ConvertLong(long Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.PX(Inch, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyInchPxConvertObject")]
                //[JSInvokableAttribute("TypologyInchPxConvertObject")]
                public static string ConvertObject(object Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.PX(Inch, Decimal, Comma, PostComma, Error);
                }

                [JSInvokable("TypologyInchPxConvertText")]
                //[JSInvokableAttribute("TypologyInchPxConvertText")]
                public static string ConvertText(string Inch, bool Decimal, bool Comma, int PostComma = Internal.TypologyPostComma, string Error = Internal.Error)
                {
                    return CTINCH.PX(Inch, Decimal, Comma, PostComma, Error);
                }
            }
        }
    }
}