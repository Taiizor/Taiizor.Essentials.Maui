﻿using Conforyon.Enum;
using System.Security.Cryptography;
using Taiizor.Essentials.Maui.Conforyon.Value;

namespace Taiizor.Essentials.Maui.Conforyon.Helper
{
    public class Converter
    {
        public static Enums.ColorType Convert(string Type, Enums.ColorType Back = Internal.ColorEnumType)
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

        public static Enums.StorageType Convert(string Type, Enums.StorageType Back = Internal.StorageEnumType)
        {
            foreach (Enums.StorageType Types in (Enums.StorageType[])Enum.GetValues(typeof(Enums.StorageType)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        public static CipherMode Convert(string Type, CipherMode Back = Internal.CryptologyCipherMode)
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