using Conforyon.Enum;
using System.Security.Cryptography;

namespace Taiizor.Essentials.Maui.Conforyon.Value
{
    internal class Internal
    {
        public const bool Clear = false;
        public const string Empty = "Empty!";
        public const string Error = "Error!";

        public const bool HashUppercase = false;

        public const int TimePostComma = 0;
        public const bool TimeComma = false;
        public const bool TimeDecimal = false;
        public const bool TimeTypeText = false;
        public const Enums.TimeType TimeEnumType = Enums.TimeType.Nanosecond;

        public const bool ColorSharp = false;
        public const string ColorType = "RGB1";
        public const Enums.ColorType ColorEnumType = Enums.ColorType.RGB1;

        public const bool SpeedText = true;
        public const int SpeedPostComma = 0;

        public const char UnicodeBracket = ',';

        public const int TypologyPostComma = 0;

        public const int StoragePostComma = 0;
        public const bool StorageComma = false;
        public const bool StorageDecimal = false;
        public const bool StorageTypeText = false;
        public const Enums.StorageType StorageEnumType = Enums.StorageType.Bit;

        public const string CryptologyMode = "CBC";
        public const bool CryptologyUppercase = false;
        public const string CryptologyIV = "QxQsRoZQws61N46H";
        public const CipherMode CryptologyCipherMode = CipherMode.CBC;
        public const string CryptologyKey = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr";

        public const bool TemperatureText = true;
        public const int TemperaturePostComma = 0;
    }
}