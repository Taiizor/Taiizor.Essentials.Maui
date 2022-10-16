using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CSDS = Conforyon.Storage.DataStorage;
using HC = Taiizor.Essentials.Maui.Conforyon.Helper.Converter;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Storage
    {
        public class Auto
        {
            [JSInvokable("StorageAutoConvertInteger")]
            //[JSInvokableAttribute("StorageAutoConvertInteger")]
            public static string ConvertInteger(int InputVariable, string InputType, bool TypeText = Internal.StorageTypeText, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.AutoDataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("StorageAutoConvertLong")]
            //[JSInvokableAttribute("StorageAutoConvertLong")]
            public static string ConvertLong(long InputVariable, string InputType, bool TypeText = Internal.StorageTypeText, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.AutoDataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("StorageAutoConvertObject")]
            //[JSInvokableAttribute("StorageAutoConvertObject")]
            public static string ConvertObject(object InputVariable, string InputType, bool TypeText = Internal.StorageTypeText, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.AutoDataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("StorageAutoConvertText")]
            //[JSInvokableAttribute("StorageAutoConvertText")]
            public static string ConvertText(string InputVariable, string InputType, bool TypeText = Internal.StorageTypeText, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.AutoDataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), TypeText, Decimal, Comma, PostComma, Error);
            }
        }
        
        public class Normal
        {
            [JSInvokable("StorageNormalConvertInteger")]
            //[JSInvokableAttribute("StorageNormalConvertInteger")]
            public static string ConvertInteger(int InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.DataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), HC.Convert(TypeConvert, Internal.StorageEnumType), Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("StorageNormalConvertLong")]
            //[JSInvokableAttribute("StorageNormalConvertLong")]
            public static string ConvertLong(long InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.DataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), HC.Convert(TypeConvert, Internal.StorageEnumType), Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("StorageNormalConvertObject")]
            //[JSInvokableAttribute("StorageNormalConvertObject")]
            public static string ConvertObject(object InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.DataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), HC.Convert(TypeConvert, Internal.StorageEnumType), Decimal, Comma, PostComma, Error);
            }

            [JSInvokable("StorageNormalConvertText")]
            //[JSInvokableAttribute("StorageNormalConvertText")]
            public static string ConvertText(string InputVariable, string InputType, string TypeConvert, bool Decimal = Internal.StorageDecimal, bool Comma = Internal.StorageComma, int PostComma = Internal.StoragePostComma, string Error = Internal.Error)
            {
                return CSDS.DataConvert(InputVariable, HC.Convert(InputType, Internal.StorageEnumType), HC.Convert(TypeConvert, Internal.StorageEnumType), Decimal, Comma, PostComma, Error);
            }
        }
    }
}