using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CTT = Conforyon.Time.Times;
using HC = Taiizor.Essentials.Maui.Conforyon.Helper.Converter;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Time
    {
        public class Auto
        {
            [JSInvokable("TimeAutoConvertInteger")]
            //[JSInvokableAttribute("TimeAutoConvertInteger")]
            public static string ConvertInteger(int InputVariable, string InputType, bool TypeText = Internal.TimeTypeText, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.AutoTimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("TimeAutoConvertLong")]
            //[JSInvokableAttribute("TimeAutoConvertLong")]
            public static string ConvertLong(long InputVariable, string InputType, bool TypeText = Internal.TimeTypeText, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.AutoTimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("TimeAutoConvertObject")]
            //[JSInvokableAttribute("TimeAutoConvertObject")]
            public static string ConvertObject(object InputVariable, string InputType, bool TypeText = Internal.TimeTypeText, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.AutoTimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("TimeAutoConvertText")]
            //[JSInvokableAttribute("TimeAutoConvertText")]
            public static string ConvertText(string InputVariable, string InputType, bool TypeText = Internal.TimeTypeText, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.AutoTimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }
        }

        public class Normal
        {
            [JSInvokable("TimeNormalConvertInteger")]
            //[JSInvokableAttribute("TimeNormalConvertInteger")]
            public static string ConvertInteger(int InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.TimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), HC.Convert(TypeConvert, Internal.TimeEnumType), Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("TimeNormalConvertLong")]
            //[JSInvokableAttribute("TimeNormalConvertLong")]
            public static string ConvertLong(long InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.TimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), HC.Convert(TypeConvert, Internal.TimeEnumType), Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("TimeNormalConvertObject")]
            //[JSInvokableAttribute("TimeNormalConvertObject")]
            public static string ConvertObject(object InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.TimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), HC.Convert(TypeConvert, Internal.TimeEnumType), Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("TimeNormalConvertText")]
            //[JSInvokableAttribute("TimeNormalConvertText")]
            public static string ConvertText(string InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.TimeDecimal, bool Comma = Internal.TimeComma, int PostComma = Internal.TimePostComma, string Error = Internal.Error)
            {
                return CTT.TimeConvert(InputVariable, HC.Convert(InputType, Internal.TimeEnumType), HC.Convert(TypeConvert, Internal.TimeEnumType), Decimal, Comma, PostComma, Error);
            }
        }
    }
}