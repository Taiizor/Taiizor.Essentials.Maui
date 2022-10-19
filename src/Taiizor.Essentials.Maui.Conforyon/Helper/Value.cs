using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CVV = Conforyon.Value.Values;
using HC = Taiizor.Essentials.Maui.Conforyon.Helper.Converter;

namespace Taiizor.Essentials.Maui.Conforyon.Helper
{
    public class Value
    {
        [JSInvokable("HelperGetValue")]
        //[JSInvokableAttribute("HelperGetValue")]
        public static string GetValue(string Method = Internal.ValueMethod, string First = Internal.ValueFirst, string Last = Internal.ValueLast, string Error = Internal.Error)
        {
            return CVV.GetValue(HC.Convert(Method, Internal.MethodEnumType), First, Last, Error);
        }

        [JSInvokable("HelperSetValue")]
        //[JSInvokableAttribute("HelperSetValue")]
        public static string SetValue(string Method = Internal.ValueMethod, string First = Internal.ValueFirst, string Last = Internal.ValueLast, string Value = Internal.ValueValue, string Error = Internal.Error)
        {
            return CVV.SetValue(HC.Convert(Method, Internal.MethodEnumType), First, Last, Value, Error);
        }

        [JSInvokable("HelperListValue")]
        //[JSInvokableAttribute("HelperListValue")]
        public static Dictionary<CEEMT, Dictionary<string, Dictionary<string, string>>> ListValue(string Method = Internal.ErrorMethod, string Error = Internal.Error)
        {
            return CVV.ListValue(HC.Convert(Method, Internal.ErrorMethodEnumType), Error);
        }

        [JSInvokable("HelperListValueJson")]
        //[JSInvokableAttribute("HelperListValueJson")]
        public static string ListValueJson(string Error = Internal.Error)
        {
            return CVV.ListValueJson(Error);
        }

        [JSInvokable("HelperResetValue")]
        //[JSInvokableAttribute("HelperResetValue")]
        public static bool ResetValue()
        {
            return CVV.ResetValue();
        }
    }
}