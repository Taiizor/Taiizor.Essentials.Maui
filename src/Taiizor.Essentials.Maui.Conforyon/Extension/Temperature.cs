using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CTC = Conforyon.Temperature.Celsius;
using CTF = Conforyon.Temperature.Fahrenheit;
using CTK = Conforyon.Temperature.Kelvin;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Temperature
    {
        public class Kelvin
        {
            public class Celsius
            {
                [JSInvokable("TemperatureKelvinCelsiusConvertInteger")]
                //[JSInvokableAttribute("TemperatureKelvinCelsiusConvertInteger")]
                public static string ConvertInteger(int Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Celsius(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureKelvinCelsiusConvertLong")]
                //[JSInvokableAttribute("TemperatureKelvinCelsiusConvertLong")]
                public static string ConvertLong(long Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Celsius(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureKelvinCelsiusConvertObject")]
                //[JSInvokableAttribute("TemperatureKelvinCelsiusConvertObject")]
                public static string ConvertObject(object Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Celsius(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureKelvinCelsiusConvertText")]
                //[JSInvokableAttribute("TemperatureKelvinCelsiusConvertText")]
                public static string ConvertText(string Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Celsius(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }
            }

            public class Fahrenheit
            {
                [JSInvokable("TemperatureKelvinFahrenheitConvertInteger")]
                //[JSInvokableAttribute("TemperatureKelvinFahrenheitConvertInteger")]
                public static string ConvertInteger(int Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Fahrenheit(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureKelvinFahrenheitConvertLong")]
                //[JSInvokableAttribute("TemperatureKelvinFahrenheitConvertLong")]
                public static string ConvertLong(long Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Fahrenheit(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureKelvinFahrenheitConvertObject")]
                //[JSInvokableAttribute("TemperatureKelvinFahrenheitConvertObject")]
                public static string ConvertObject(object Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Fahrenheit(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureKelvinFahrenheitConvertText")]
                //[JSInvokableAttribute("TemperatureKelvinFahrenheitConvertText")]
                public static string ConvertText(string Kelvin, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTK.Fahrenheit(Kelvin, Decimal, Comma, PostComma, Text, Error);
                }
            }
        }

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
            public class Kelvin
            {
                [JSInvokable("TemperatureFahrenheitKelvinConvertInteger")]
                //[JSInvokableAttribute("TemperatureFahrenheitKelvinConvertInteger")]
                public static string ConvertInteger(int Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Kelvin(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureFahrenheitKelvinConvertLong")]
                //[JSInvokableAttribute("TemperatureFahrenheitKelvinConvertLong")]
                public static string ConvertLong(long Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Kelvin(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureFahrenheitKelvinConvertObject")]
                //[JSInvokableAttribute("TemperatureFahrenheitKelvinConvertObject")]
                public static string ConvertObject(object Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Kelvin(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureFahrenheitKelvinConvertText")]
                //[JSInvokableAttribute("TemperatureFahrenheitKelvinConvertText")]
                public static string ConvertText(string Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Kelvin(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }
            }

            public class Celsius
            {
                [JSInvokable("TemperatureFahrenheitCelsiusConvertInteger")]
                //[JSInvokableAttribute("TemperatureFahrenheitCelsiusConvertInteger")]
                public static string ConvertInteger(int Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Celsius(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureFahrenheitCelsiusConvertLong")]
                //[JSInvokableAttribute("TemperatureFahrenheitCelsiusConvertLong")]
                public static string ConvertLong(long Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Celsius(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureFahrenheitCelsiusConvertObject")]
                //[JSInvokableAttribute("TemperatureFahrenheitCelsiusConvertObject")]
                public static string ConvertObject(object Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Celsius(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }

                [JSInvokable("TemperatureFahrenheitCelsiusConvertText")]
                //[JSInvokableAttribute("TemperatureFahrenheitCelsiusConvertText")]
                public static string ConvertText(string Fahrenheit, bool Decimal, bool Comma, int PostComma = Internal.TemperaturePostComma, bool Text = Internal.TemperatureText, string Error = Internal.Error)
                {
                    return CTF.Celsius(Fahrenheit, Decimal, Comma, PostComma, Text, Error);
                }
            }
        }
    }
}