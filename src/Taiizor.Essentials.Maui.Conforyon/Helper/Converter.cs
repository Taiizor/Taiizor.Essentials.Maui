using Conforyon.Enum;
using System.Security.Cryptography;

namespace Taiizor.Essentials.Maui.Conforyon.Helper
{
    public class Converter
    {
        public static Enums.ColorType Convert(string Type, Enums.ColorType Back = Enums.ColorType.RGB1)
        {
            foreach (Enums.ColorType Types in (Enums.ColorType[])Enum.GetValues(typeof(Enums.ColorType)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        public static CipherMode Convert(string Type, CipherMode Back = CipherMode.CBC)
        {
            foreach (CipherMode Types in (CipherMode[])Enum.GetValues(typeof(CipherMode)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        public static bool Check(object Text, object Type)
        {
            return Check($"{Text}", $"{Type}");
        }

        private static bool Check(string Text, string Type)
        {
            if (Text == Type || Text.ToUpper() == Type || Text.ToUpperInvariant() == Type || Text == Type.ToLower() || Text == Type.ToLowerInvariant())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
