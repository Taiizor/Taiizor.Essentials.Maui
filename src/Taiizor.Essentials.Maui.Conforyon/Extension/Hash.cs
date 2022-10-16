using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CHFILE = Conforyon.Hash.FILE;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Hash
    {
        public class File
        {
            public class Md5
            {
                [JSInvokable("HashFileMd5EncryptObject")]
                //[JSInvokableAttribute("HashFileMd5EncryptObject")]
                public static string EncryptObject(object Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.MD5(Path, Uppercase, Error);
                }

                [JSInvokable("HashFileMd5EncryptText")]
                //[JSInvokableAttribute("HashFileMd5EncryptText")]
                public static string EncryptText(string Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.MD5(Path, Uppercase, Error);
                }
            }

            public class Sha1
            {
                [JSInvokable("HashFileSha1EncryptObject")]
                //[JSInvokableAttribute("HashFileSha1EncryptObject")]
                public static string EncryptObject(object Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA1(Path, Uppercase, Error);
                }

                [JSInvokable("HashFileSha1EncryptText")]
                //[JSInvokableAttribute("HashFileSha1EncryptText")]
                public static string EncryptText(string Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA1(Path, Uppercase, Error);
                }
            }

            public class Sha256
            {
                [JSInvokable("HashFileSha256EncryptObject")]
                //[JSInvokableAttribute("HashFileSha256EncryptObject")]
                public static string EncryptObject(object Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA256(Path, Uppercase, Error);
                }

                [JSInvokable("HashFileSha256EncryptText")]
                //[JSInvokableAttribute("HashFileSha256EncryptText")]
                public static string EncryptText(string Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA256(Path, Uppercase, Error);
                }
            }

            public class Sha384
            {
                [JSInvokable("HashFileSha384EncryptObject")]
                //[JSInvokableAttribute("HashFileSha384EncryptObject")]
                public static string EncryptObject(object Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA384(Path, Uppercase, Error);
                }

                [JSInvokable("HashFileSha384EncryptText")]
                //[JSInvokableAttribute("HashFileSha384EncryptText")]
                public static string EncryptText(string Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA384(Path, Uppercase, Error);
                }
            }

            public class Sha512
            {
                [JSInvokable("HashFileSha512EncryptObject")]
                //[JSInvokableAttribute("HashFileSha512EncryptObject")]
                public static string EncryptObject(object Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA512(Path, Uppercase, Error);
                }

                [JSInvokable("HashFileSha512EncryptText")]
                //[JSInvokableAttribute("HashFileSha512EncryptText")]
                public static string EncryptText(string Path, bool Uppercase = Internal.HashUppercase, string Error = Internal.Error)
                {
                    return CHFILE.SHA512(Path, Uppercase, Error);
                }
            }
        }
    }
}