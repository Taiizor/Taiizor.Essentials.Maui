using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CTC = Conforyon.Temperature.Celsius;
using CTK = Conforyon.Temperature.Kelvin;
using CTF = Conforyon.Temperature.Fahrenheit;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Temperature
    {
        public class Celsius
        {
            public class Kelvin
            {
                [JSInvokable("TemperatureCelsiusKelvinConvertInteger")]
                //[JSInvokableAttribute("TemperatureCelsiusKelvinConvertInteger")]
                public static string ConvertInteger(int Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Kelvin(Celsius, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureCelsiusKelvinConvertLong")]
                //[JSInvokableAttribute("TemperatureCelsiusKelvinConvertLong")]
                public static string ConvertLong(long Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Kelvin(Celsius, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureCelsiusKelvinConvertObject")]
                //[JSInvokableAttribute("TemperatureCelsiusKelvinConvertObject")]
                public static string ConvertObject(object Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Kelvin(Celsius, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureCelsiusKelvinConvertText")]
                //[JSInvokableAttribute("TemperatureCelsiusKelvinConvertText")]
                public static string ConvertText(string Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Kelvin(Celsius, Decimal, Comma, PostComma, Text, Error);
                }
            }
            
            public class Fahrenheit
            {
                [JSInvokable("TemperatureCelsiusFahrenheitConvertInteger")]
                //[JSInvokableAttribute("TemperatureCelsiusFahrenheitConvertInteger")]
                public static string ConvertInteger(int Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Fahrenheit(Celsius, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureCelsiusFahrenheitConvertLong")]
                //[JSInvokableAttribute("TemperatureCelsiusFahrenheitConvertLong")]
                public static string ConvertLong(long Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Fahrenheit(Celsius, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureCelsiusFahrenheitConvertObject")]
                //[JSInvokableAttribute("TemperatureCelsiusFahrenheitConvertObject")]
                public static string ConvertObject(object Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Fahrenheit(Celsius, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureCelsiusFahrenheitConvertText")]
                //[JSInvokableAttribute("TemperatureCelsiusFahrenheitConvertText")]
                public static string ConvertText(string Celsius, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTC.Fahrenheit(Celsius, Decimal, Comma, PostComma, Text, Error);
                }
            }
        }

        public class Fahrenheit
        {

        }

        public class Kelvin
        {
            
        }
    }
}