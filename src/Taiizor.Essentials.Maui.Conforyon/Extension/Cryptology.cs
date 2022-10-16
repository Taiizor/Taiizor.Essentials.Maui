using Microsoft.JSInterop;
using System.Security.Cryptography;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CCAES = Conforyon.Cryptology.AES;
using CCBASE = Conforyon.Cryptology.BASE;
using CCTEXT = Conforyon.Cryptology.TEXT;
using HC = Taiizor.Essentials.Maui.Conforyon.Helper.Converter;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Cryptology
    {
        public class Aes
        {
            [JSInvokable("CryptologyAesEncryptInteger")]
            //[JSInvokableAttribute("CryptologyAesEncryptInteger")]
            public static string EncryptInteger(int Number, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Encrypt(Number, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptLong")]
            //[JSInvokableAttribute("CryptologyAesEncryptLong")]
            public static string EncryptLong(long Number, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Encrypt(Number, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptDouble")]
            //[JSInvokableAttribute("CryptologyAesEncryptDouble")]
            public static string EncryptDouble(double Number, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Encrypt(Number, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptFloat")]
            //[JSInvokableAttribute("CryptologyAesEncryptFloat")]
            public static string EncryptFloat(float Number, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Encrypt(Number, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptObject")]
            //[JSInvokableAttribute("CryptologyAesEncryptObject")]
            public static string EncryptObject(object Value, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Encrypt(Value, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesEncryptText")]
            //[JSInvokableAttribute("CryptologyAesEncryptText")]
            public static string EncryptText(string Text, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Encrypt(Text, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesDecryptObject")]
            //[JSInvokableAttribute("CryptologyAesDecryptObject")]
            public static string DecryptObject(object Base, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Decrypt(Base, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }

            [JSInvokable("CryptologyAesDecryptText")]
            //[JSInvokableAttribute("CryptologyAesDecryptText")]
            public static string DecryptText(string Base, string IV = Internal.CryptologyIV, string Key = Internal.CryptologyKey, string Mode = Internal.CryptologyMode, string Error = Internal.Error)
            {
                return CCAES.Decrypt(Base, IV, Key, HC.Convert(Mode, CipherMode.CBC), Error);
            }
        }

        public class Base
        {
            [JSInvokable("CryptologyBaseDecryptObject")]
            //[JSInvokableAttribute("CryptologyBaseDecryptObject")]
            public static string DecryptObject(object Base, string Error = Internal.Error)
            {
                return CCBASE.TEXT(Base, Error);
            }

            [JSInvokable("CryptologyBaseDecryptText")]
            //[JSInvokableAttribute("CryptologyBaseDecryptText")]
            public static string DecryptText(string Base, string Error = Internal.Error)
            {
                return CCBASE.TEXT(Base, Error);
            }
        }

        public class Text
        {
            public class Base
            {
                [JSInvokable("CryptologyTextBaseEncryptInteger")]
                //[JSInvokableAttribute("CryptologyTextBaseEncryptInteger")]
                public static string EncryptInteger(int Number, string Error = Internal.Error)
                {
                    return CCTEXT.BASE(Number, Error);
                }

                [JSInvokable("CryptologyTextBaseEncryptLong")]
                //[JSInvokableAttribute("CryptologyTextBaseEncryptLong")]
                public static string EncryptLong(long Number, string Error = Internal.Error)
                {
                    return CCTEXT.BASE(Number, Error);
                }

                [JSInvokable("CryptologyTextBaseEncryptDouble")]
                //[JSInvokableAttribute("CryptologyTextBaseEncryptDouble")]
                public static string EncryptDouble(double Number, string Error = Internal.Error)
                {
                    return CCTEXT.BASE(Number, Error);
                }

                [JSInvokable("CryptologyTextBaseEncryptFloat")]
                //[JSInvokableAttribute("CryptologyTextBaseEncryptFloat")]
                public static string EncryptFloat(float Number, string Error = Internal.Error)
                {
                    return CCTEXT.BASE(Number, Error);
                }

                [JSInvokable("CryptologyTextBaseEncryptObject")]
                //[JSInvokableAttribute("CryptologyTextBaseEncryptObject")]
                public static string EncryptObject(object Value, string Error = Internal.Error)
                {
                    return CCTEXT.BASE(Value, Error);
                }

                [JSInvokable("CryptologyTextBaseEncryptText")]
                //[JSInvokableAttribute("CryptologyTextBaseEncryptText")]
                public static string EncryptText(string Text, string Error = Internal.Error)
                {
                    return CCTEXT.BASE(Text, Error);
                }
            }

            public class Md5
            {
                [JSInvokable("CryptologyTextMd5EncryptInteger")]
                //[JSInvokableAttribute("CryptologyTextMd5EncryptInteger")]
                public static string EncryptInteger(int Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.MD5(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextMd5EncryptLong")]
                //[JSInvokableAttribute("CryptologyTextMd5EncryptLong")]
                public static string EncryptLong(long Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.MD5(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextMd5EncryptDouble")]
                //[JSInvokableAttribute("CryptologyTextMd5EncryptDouble")]
                public static string EncryptDouble(double Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.MD5(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextMd5EncryptFloat")]
                //[JSInvokableAttribute("CryptologyTextMd5EncryptFloat")]
                public static string EncryptFloat(float Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.MD5(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextMd5EncryptObject")]
                //[JSInvokableAttribute("CryptologyTextMd5EncryptObject")]
                public static string EncryptObject(object Value, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.MD5(Value, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextMd5EncryptText")]
                //[JSInvokableAttribute("CryptologyTextMd5EncryptText")]
                public static string EncryptText(string Text, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.MD5(Text, Uppercase, Error);
                }
            }

            public class Sha1
            {
                [JSInvokable("CryptologyTextSha1EncryptInteger")]
                //[JSInvokableAttribute("CryptologyTextSha1EncryptInteger")]
                public static string EncryptInteger(int Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA1(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha1EncryptLong")]
                //[JSInvokableAttribute("CryptologyTextSha1EncryptLong")]
                public static string EncryptLong(long Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA1(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha1EncryptDouble")]
                //[JSInvokableAttribute("CryptologyTextSha1EncryptDouble")]
                public static string EncryptDouble(double Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA1(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha1EncryptFloat")]
                //[JSInvokableAttribute("CryptologyTextSha1EncryptFloat")]
                public static string EncryptFloat(float Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA1(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha1EncryptObject")]
                //[JSInvokableAttribute("CryptologyTextSha1EncryptObject")]
                public static string EncryptObject(object Value, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA1(Value, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha1EncryptText")]
                //[JSInvokableAttribute("CryptologyTextSha1EncryptText")]
                public static string EncryptText(string Text, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA1(Text, Uppercase, Error);
                }
            }

            public class Sha256
            {
                [JSInvokable("CryptologyTextSha256EncryptInteger")]
                //[JSInvokableAttribute("CryptologyTextSha256EncryptInteger")]
                public static string EncryptInteger(int Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA256(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha256EncryptLong")]
                //[JSInvokableAttribute("CryptologyTextSha256EncryptLong")]
                public static string EncryptLong(long Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA256(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha256EncryptDouble")]
                //[JSInvokableAttribute("CryptologyTextSha256EncryptDouble")]
                public static string EncryptDouble(double Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA256(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha256EncryptFloat")]
                //[JSInvokableAttribute("CryptologyTextSha256EncryptFloat")]
                public static string EncryptFloat(float Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA256(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha256EncryptObject")]
                //[JSInvokableAttribute("CryptologyTextSha256EncryptObject")]
                public static string EncryptObject(object Value, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA256(Value, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha256EncryptText")]
                //[JSInvokableAttribute("CryptologyTextSha256EncryptText")]
                public static string EncryptText(string Text, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA256(Text, Uppercase, Error);
                }
            }

            public class Sha384
            {
                [JSInvokable("CryptologyTextSha384EncryptInteger")]
                //[JSInvokableAttribute("CryptologyTextSha384EncryptInteger")]
                public static string EncryptInteger(int Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA384(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha384EncryptLong")]
                //[JSInvokableAttribute("CryptologyTextSha384EncryptLong")]
                public static string EncryptLong(long Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA384(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha384EncryptDouble")]
                //[JSInvokableAttribute("CryptologyTextSha384EncryptDouble")]
                public static string EncryptDouble(double Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA384(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha384EncryptFloat")]
                //[JSInvokableAttribute("CryptologyTextSha384EncryptFloat")]
                public static string EncryptFloat(float Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA384(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha384EncryptObject")]
                //[JSInvokableAttribute("CryptologyTextSha384EncryptObject")]
                public static string EncryptObject(object Value, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA384(Value, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha384EncryptText")]
                //[JSInvokableAttribute("CryptologyTextSha384EncryptText")]
                public static string EncryptText(string Text, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA384(Text, Uppercase, Error);
                }
            }

            public class Sha512
            {
                [JSInvokable("CryptologyTextSha512EncryptInteger")]
                //[JSInvokableAttribute("CryptologyTextSha512EncryptInteger")]
                public static string EncryptInteger(int Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA512(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha512EncryptLong")]
                //[JSInvokableAttribute("CryptologyTextSha512EncryptLong")]
                public static string EncryptLong(long Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA512(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha512EncryptDouble")]
                //[JSInvokableAttribute("CryptologyTextSha512EncryptDouble")]
                public static string EncryptDouble(double Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA512(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha512EncryptFloat")]
                //[JSInvokableAttribute("CryptologyTextSha512EncryptFloat")]
                public static string EncryptFloat(float Number, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA512(Number, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha512EncryptObject")]
                //[JSInvokableAttribute("CryptologyTextSha512EncryptObject")]
                public static string EncryptObject(object Value, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA512(Value, Uppercase, Error);
                }

                [JSInvokable("CryptologyTextSha512EncryptText")]
                //[JSInvokableAttribute("CryptologyTextSha512EncryptText")]
                public static string EncryptText(string Text, bool Uppercase = Internal.CryptologyUppercase, string Error = Internal.Error)
                {
                    return CCTEXT.SHA512(Text, Uppercase, Error);
                }
            }
        }
    }
}