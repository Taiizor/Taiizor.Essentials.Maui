using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CUASCII = Conforyon.Unicode.ASCII;
using CUCHAR = Conforyon.Unicode.CHAR;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Unicode
    {
        public class Ascii
        {
            [JSInvokable("UnicodeAsciiCharInteger")]
            //[JSInvokableAttribute("UnicodeAsciiCharInteger")]
            public static string CharInteger(int Ascii, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUASCII.CHAR(Ascii, Bracket, Error);
            }

            [JSInvokable("UnicodeAsciiCharLong")]
            //[JSInvokableAttribute("UnicodeAsciiCharLong")]
            public static string CharLong(long Ascii, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUASCII.CHAR(Ascii, Bracket, Error);
            }

            [JSInvokable("UnicodeAsciiCharDouble")]
            //[JSInvokableAttribute("UnicodeAsciiCharDouble")]
            public static string CharDouble(double Ascii, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUASCII.CHAR(Ascii, Bracket, Error);
            }

            [JSInvokable("UnicodeAsciiCharFloat")]
            //[JSInvokableAttribute("UnicodeAsciiCharFloat")]
            public static string CharFloat(float Ascii, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUASCII.CHAR(Ascii, Bracket, Error);
            }

            [JSInvokable("UnicodeAsciiCharChar")]
            //[JSInvokableAttribute("UnicodeAsciiCharChar")]
            public static string CharChar(char Ascii, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUASCII.CHAR(Ascii, Bracket, Error);
            }

            [JSInvokable("UnicodeAsciiCharObject")]
            //[JSInvokableAttribute("UnicodeAsciiCharObject")]
            public static string CharObject(object Ascii, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUASCII.CHAR(Ascii, Bracket, Error);
            }

            [JSInvokable("UnicodeAsciiCharText")]
            //[JSInvokableAttribute("UnicodeAsciiCharText")]
            public static string CharText(string Ascii, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUASCII.CHAR(Ascii, Bracket, Error);
            }
        }

        public class Char
        {
            [JSInvokable("UnicodeCharAsciiInteger")]
            //[JSInvokableAttribute("UnicodeCharAsciiInteger")]
            public static string AsciiInteger(int Char, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUCHAR.ASCII(Char, Bracket, Error);
            }

            [JSInvokable("UnicodeCharAsciiLong")]
            //[JSInvokableAttribute("UnicodeCharAsciiLong")]
            public static string AsciiLong(long Char, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUCHAR.ASCII(Char, Bracket, Error);
            }

            [JSInvokable("UnicodeCharAsciiDouble")]
            //[JSInvokableAttribute("UnicodeCharAsciiDouble")]
            public static string AsciiDouble(double Char, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUCHAR.ASCII(Char, Bracket, Error);
            }

            [JSInvokable("UnicodeCharAsciiFloat")]
            //[JSInvokableAttribute("UnicodeCharAsciiFloat")]
            public static string AsciiFloat(float Char, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUCHAR.ASCII(Char, Bracket, Error);
            }

            [JSInvokable("UnicodeCharAsciiChar")]
            //[JSInvokableAttribute("UnicodeCharAsciiChar")]
            public static string AsciiChar(char Char, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUCHAR.ASCII(Char, Bracket, Error);
            }

            [JSInvokable("UnicodeCharAsciiObject")]
            //[JSInvokableAttribute("UnicodeCharAsciiObject")]
            public static string AsciiObject(object Char, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUCHAR.ASCII(Char, Bracket, Error);
            }

            [JSInvokable("UnicodeCharAsciiText")]
            //[JSInvokableAttribute("UnicodeCharAsciiText")]
            public static string AsciiText(string Char, char Bracket = Internal.UnicodeBracket, string Error = Internal.Error)
            {
                return CUCHAR.ASCII(Char, Bracket, Error);
            }
        }
    }
}