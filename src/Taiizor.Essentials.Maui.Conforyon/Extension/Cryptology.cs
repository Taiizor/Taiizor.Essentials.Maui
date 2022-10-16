using Microsoft.JSInterop;
using System.Security.Cryptography;
using CCAES = Conforyon.Cryptology.AES;
using CCBASE = Conforyon.Cryptology.BASE;
using CCTEXT = Conforyon.Cryptology.TEXT;
using HC = Taiizor.Essentials.Maui.Conforyon.Helper.Converter;
using Conforyon.Enum;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Cryptology
    {
        public class Aes
        {
            [JSInvokable("CryptologyAesEncryptInteger")]
            //[JSInvokableAttribute("CryptologyAesEncryptInteger")]
            public static string EncryptInteger(int Text, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Encrypt(Text, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }
            
            [JSInvokable("CryptologyAesEncryptLong")]
            //[JSInvokableAttribute("CryptologyAesEncryptLong")]
            public static string EncryptLong(long Text, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Encrypt(Text, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptDouble")]
            //[JSInvokableAttribute("CryptologyAesEncryptDouble")]
            public static string EncryptDouble(double Text, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Encrypt(Text, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptFloat")]
            //[JSInvokableAttribute("CryptologyAesEncryptFloat")]
            public static string EncryptFloat(float Text, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Encrypt(Text, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptObject")]
            //[JSInvokableAttribute("CryptologyAesEncryptObject")]
            public static string EncryptObject(object Text, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Encrypt(Text, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptText")]
            //[JSInvokableAttribute("CryptologyAesEncryptText")]
            public static string EncryptText(string Text, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Encrypt(Text, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesDecryptObject")]
            //[JSInvokableAttribute("CryptologyAesDecryptObject")]
            public static string DecryptObject(object Base, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Decrypt(Base, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesDecryptText")]
            //[JSInvokableAttribute("CryptologyAesDecryptText")]
            public static string DecryptText(string Base, string IV = "QxQsRoZQws61N46H", string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr", string Mode = "CBC", string Error = "Error!")
            {
                return CCAES.Decrypt(Base, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }
        }
    }
}