console.log('%cConforyon Blazor Javascript has started.', 'color: #FFC000');


var Conforyon = {};


Conforyon.Clear = false;
Conforyon.Empty = "Empty!";
Conforyon.Error = "Error!";


Conforyon.Hash = {};
Conforyon.Hash.File = {};
Conforyon.Hash.File.Md5 = {};
Conforyon.Hash.File.Sha1 = {};
Conforyon.Hash.File.Sha256 = {};
Conforyon.Hash.File.Sha384 = {};
Conforyon.Hash.File.Sha512 = {};
Conforyon.Hash.Uppercase = false;

Conforyon.Board = {};
Conforyon.Board.Text = {};
Conforyon.Board.Audio = {};

Conforyon.Speed = {};
Conforyon.Speed.Mph = {};
Conforyon.Speed.Kph = {};
Conforyon.Speed.Text = true;
Conforyon.Speed.Mph.Kph = {};
Conforyon.Speed.Kph.Mph = {};
Conforyon.Speed.PostComma = 0;

Conforyon.Color = {};
Conforyon.Color.Hex = {};
Conforyon.Color.Rgb = {};
Conforyon.Color.Type = "RGB1";
Conforyon.Color.Sharp = false;

Conforyon.Storage = {};
Conforyon.Storage.Auto = {};
Conforyon.Storage.Normal = {};
Conforyon.Storage.Comma = false;
Conforyon.Storage.PostComma = 0;
Conforyon.Storage.Decimal = false;
Conforyon.Storage.TypeText = false;

Conforyon.Cryptology = {};
Conforyon.Cryptology.Aes = {};
Conforyon.Cryptology.Base = {};
Conforyon.Cryptology.Text = {};
Conforyon.Cryptology.Text.Md5 = {};
Conforyon.Cryptology.Text.Sha1 = {};
Conforyon.Cryptology.Text.Base = {};
Conforyon.Cryptology.Mode = "CBC";
Conforyon.Cryptology.Text.Sha256 = {};
Conforyon.Cryptology.Text.Sha384 = {};
Conforyon.Cryptology.Text.Sha512 = {};
Conforyon.Cryptology.Uppercase = false;
Conforyon.Cryptology.IV = "QxQsRoZQws61N46H";
Conforyon.Cryptology.Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr";

Conforyon.Temperature = {};
Conforyon.Temperature.Text = true;
Conforyon.Temperature.Kelvin = {};
Conforyon.Temperature.Celsius = {};
Conforyon.Temperature.PostComma = 0;
Conforyon.Temperature.Fahrenheit = {};
Conforyon.Temperature.Kelvin.Celsius = {};
Conforyon.Temperature.Celsius.Kelvin = {};
Conforyon.Temperature.Kelvin.Fahrenheit = {};
Conforyon.Temperature.Fahrenheit.Kelvin = {};
Conforyon.Temperature.Celsius.Fahrenheit = {};
Conforyon.Temperature.Fahrenheit.Celsius = {};


Conforyon.Board.Audio.CopyPath = function (Path) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyPath", Path);
}

Conforyon.Board.Audio.CopyByte = function (Bytes) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyByte", Bytes);
}

Conforyon.Board.Audio.PasteStream = function (Clear = Conforyon.Clear) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioPasteStream", Clear);
}


Conforyon.Board.Text.CopyInteger = function (Number) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyInteger", Number);
}

Conforyon.Board.Text.CopyLong = function (Number) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyLong", Number);
}

Conforyon.Board.Text.CopyDouble = function (Number) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyDouble", Number);
}

Conforyon.Board.Text.CopyFloat = function (Number) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyFloat", Number);
}

Conforyon.Board.Text.CopyObject = function (Value) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyObject", Value);
}

Conforyon.Board.Text.CopyText = function (Text) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyText", Text);
}

Conforyon.Board.Text.PasteText = function (Clear = Conforyon.Clear, Back = Conforyon.Empty) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextPasteText", Clear, Back);
}



Conforyon.Color.Hex.RgbObject = function (Hex, Type = Conforyon.Color.Type, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorHexRgbObject", Hex, Type, Error);
}

Conforyon.Color.Hex.RgbText = function (Hex, Type = Conforyon.Color.Type, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorHexRgbText", Hex, Type, Error);
}


Conforyon.Color.Rgb.HexInteger = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexInteger", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexLong = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexLong", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexObject = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexObject", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexText = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexText", R, G, B, Sharp, Error);
}



Conforyon.Cryptology.Aes.EncryptInteger = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptInteger", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptLong = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptLong", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptDouble = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptDouble", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptFloat = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptFloat", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptObject = function (Value, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptObject", Value, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptText = function (Text, IV = IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptText", Text, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.DecryptObject = function (Base, IV = IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesDecryptObject", Base, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.DecryptText = function (Base, IV = IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesDecryptText", Base, IV, Key, Mode, Error);
}


Conforyon.Cryptology.Base.DecryptObject = function (Base, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyBaseDecryptObject", Base, Error);
}

Conforyon.Cryptology.Base.DecryptText = function (Base, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyBaseDecryptText", Base, Error);
}


Conforyon.Cryptology.Text.Base.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Md5.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha1.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha256.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha384.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha512.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptText", Text, Uppercase, Error);
}



Conforyon.Hash.File.Md5.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileMd5EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Md5.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileMd5EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha1.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha1EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha1.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha1EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha256.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha256EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha256.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha256EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha384.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha384EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha384.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha384EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha512.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha512EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha512.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha512EncryptText", Path, Uppercase, Error);
}



Conforyon.Speed.Kph.Mph.ConvertInteger = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertInteger", Kilometers, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Kph.Mph.ConvertLong = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertLong", Kilometers, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Kph.Mph.ConvertObject = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertObject", Kilometers, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Kph.Mph.ConvertText = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertText", Kilometers, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Speed.Mph.Kph.ConvertInteger = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertInteger", Miles, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Mph.Kph.ConvertLong = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertLong", Miles, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Mph.Kph.ConvertObject = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertObject", Miles, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Mph.Kph.ConvertText = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertText", Miles, Decimal, Comma, PostComma, Text, Error);
}



Conforyon.Storage.Auto.ConvertInteger = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertInteger", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Auto.ConvertLong = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertLong", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Auto.ConvertObject = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertObject", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Auto.ConvertText = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertText", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}


Conforyon.Storage.Normal.ConvertInteger = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertInteger", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Normal.ConvertLong = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertLong", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Normal.ConvertObject = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertObject", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Normal.ConvertText = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertText", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}



Conforyon.Temperature.Kelvin.Celsius.ConvertInteger = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertInteger", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Celsius.ConvertLong = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertLong", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Celsius.ConvertObject = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertObject", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Celsius.ConvertText = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertText", Kelvin, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Kelvin.Fahrenheit.ConvertInteger = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertInteger", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Fahrenheit.ConvertLong = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertLong", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Fahrenheit.ConvertObject = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertObject", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Fahrenheit.ConvertText = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertText", Kelvin, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Celsius.Kelvin.ConvertInteger = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertInteger", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Kelvin.ConvertLong = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertLong", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Kelvin.ConvertObject = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertObject", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Kelvin.ConvertText = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertText", Celsius, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Celsius.Fahrenheit.ConvertInteger = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertInteger", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Fahrenheit.ConvertLong = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertLong", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Fahrenheit.ConvertObject = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertObject", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Fahrenheit.ConvertText = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertText", Celsius, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Fahrenheit.Kelvin.ConvertInteger = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertInteger", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Kelvin.ConvertLong = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertLong", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Kelvin.ConvertObject = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertObject", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Kelvin.ConvertText = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertText", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Fahrenheit.Celsius.ConvertInteger = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertInteger", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Celsius.ConvertLong = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertLong", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Celsius.ConvertObject = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertObject", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Celsius.ConvertText = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertText", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}