console.log('%cConforyon Blazor Javascript has started.', 'color: #FFC000');


var Conforyon = {};


Conforyon.Clear = false;
Conforyon.Empty = "Empty!";
Conforyon.Error = "Error!";


Conforyon.Enum = {};

Conforyon.Enum.ColorType = {
    RGB1: "RGB1",
    RGB2: "RGB2",
    RGB3: "RGB3",
    RRGGBB1: "RRGGBB1",
    RRGGBB2: "RRGGBB2",
    RRGGBB3: "RRGGBB3",
    RR: "RR",
    GG: "GG",
    BB: "BB",
    OnlyR: "OnlyR",
    OnlyG: "OnlyG",
    OnlyB: "OnlyB"
};

Conforyon.Enum.CryptologyType = {
    AES: "AES",
    MD5: "MD5",
    SHA1: "SHA1",
    SHA256: "SHA256",
    SHA384: "SHA384",
    SHA512: "SHA512",
    TEXT: "TEXT",
    BASE: "BASE"
};

Conforyon.Enum.CryptologyCipherMode = {
    CBC: "CBC",
    ECB: "ECB",
    OFB: "OFB",
    CFB: "CFB",
    CTS: "CTS"
};

Conforyon.Enum.HashType = {
    MD5: "MD5",
    SHA1: "SHA1",
    SHA256: "SHA256",
    SHA384: "SHA384",
    SHA512: "SHA512"
};

Conforyon.Enum.LengthType = {
    MM: "MM",
    CM: "CM",
    DM: "DM",
    M: "M",
    DAM: "DAM",
    HM: "HM",
    KM: "KM"
};

Conforyon.Enum.SpeedType = {
    MPH: "MPH",
    KPH: "KPH"
};

Conforyon.Enum.StorageType = {
    Bit: "Bit",
    Byte: "Byte",
    KB: "KB",
    MB: "MB",
    GB: "GB",
    TB: "TB",
    PB: "PB",
    EB: "EB",
    ZB: "ZB",
    YB: "YB"
}

Conforyon.Enum.TimeType = {
    Nanosecond: "Nanosecond",
    Microsecond: "Microsecond",
    Millisecond: "Millisecond",
    Second: "Second",
    Minute: "Minute",
    Hour: "Hour",
    Day: "Day",
    Week: "Week",
    Year: "Year",
    Century: "Century",
    Millennium: "Millennium"
}

Conforyon.Enum.WeightType = {
    Milligram: "Milligram",
    Gram: "Gram",
    KG: "KG"
};

Conforyon.Enum.TypographyType = {
    INCH: "INCH",
    CM: "CM",
    PX: "PX"
};

Conforyon.Enum.TemperatureType = {
    Kelvin: "Kelvin",
    Celsius: "Celsius",
    Fahrenheit: "Fahrenheit"
};

Conforyon.Enum.MethodType = {
    DataStorage: "DataStorage",
    Temperature: "Temperature",
    Typography: "Typography",
    Speed: "Speed",
    Error: "Error",
    Time: "Time"
};


Conforyon.Helper = {};
Conforyon.Helper.Value = {};
Conforyon.Helper.Culture = {};
Conforyon.Helper.Value.Value = "8";
Conforyon.Helper.Value.First = "Bit";
Conforyon.Helper.Value.Last = "Byte";
Conforyon.Helper.Culture.Name = "en-GB";
Conforyon.Helper.Culture.Override = false;
Conforyon.Helper.Value.ErrorMethod = Conforyon.Enum.MethodType.Error;
Conforyon.Helper.Value.ValueMethod = Conforyon.Enum.MethodType.DataStorage;


Conforyon.Time = {};
Conforyon.Time.Auto = {};
Conforyon.Time.Normal = {};
Conforyon.Time.Comma = false;
Conforyon.Time.PostComma = 0;
Conforyon.Time.Decimal = false;
Conforyon.Time.TypeText = false;

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
Conforyon.Color.Sharp = false;
Conforyon.Color.Type = Conforyon.Enum.ColorType.RGB1;

Conforyon.Unicode = {};
Conforyon.Unicode.Char = {};
Conforyon.Unicode.Ascii = {};
Conforyon.Unicode.Bracket = ',';

Conforyon.Typology = {};
Conforyon.Typology.Cm = {};
Conforyon.Typology.Px = {};
Conforyon.Typology.Inch = {};
Conforyon.Typology.Cm.Px = {};
Conforyon.Typology.Px.Cm = {};
Conforyon.Typology.Cm.Inch = {};
Conforyon.Typology.Px.Inch = {};
Conforyon.Typology.Inch.Cm = {};
Conforyon.Typology.Inch.Px = {};
Conforyon.Typology.PostComma = 0;

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
Conforyon.Cryptology.Text.Sha256 = {};
Conforyon.Cryptology.Text.Sha384 = {};
Conforyon.Cryptology.Text.Sha512 = {};
Conforyon.Cryptology.Uppercase = false;
Conforyon.Cryptology.IV = "QxQsRoZQws61N46H";
Conforyon.Cryptology.Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr";
Conforyon.Cryptology.Mode = Conforyon.Enum.CryptologyCipherMode.CBC;

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



Conforyon.Helper.Value.Get = function (Method = Conforyon.Helper.Value.ValueMethod, First = Conforyon.Helper.Value.First, Last = Conforyon.Helper.Value.Last, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperGetValue", Method, First, Last, Error);
}

Conforyon.Helper.Value.Set = function (Method = Conforyon.Helper.Value.ValueMethod, First = Conforyon.Helper.Value.First, Last = Conforyon.Helper.Value.Last, Value = Conforyon.Helper.Value.Value, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperSetValue", Method, First, Last, Value, Error);
}

Conforyon.Helper.Value.List = function (Method = Conforyon.Helper.Value.ErrorMethod, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperListValue", Method, Error);
}

Conforyon.Helper.Value.ListJson = function (Method = Conforyon.Helper.Value.ErrorMethod, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperListValueJson", Method, Error);
}

Conforyon.Helper.Value.Reset = function () {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperResetValue");
}


Conforyon.Helper.Culture.GetName = function (Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperGetCultureName", Error);
}

Conforyon.Helper.Culture.GetUiName = function (Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperGetUICultureName", Error);
}

Conforyon.Helper.Culture.GetThreadName = function (Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperGetThreadCultureName", Error);
}

Conforyon.Helper.Culture.GetThreadUiName = function (Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperGetThreadUICultureName", Error);
}

Conforyon.Helper.Culture.Set = function (Name = Conforyon.Helper.Culture.Name, Override = Conforyon.Helper.Culture.Override) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperSetCulture", Name, Override);
}

Conforyon.Helper.Culture.SetAll = function (Name = Conforyon.Helper.Culture.Name, Override = Conforyon.Helper.Culture.Override) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperSetAllCulture", Name, Override);
}

Conforyon.Helper.Culture.SetUi = function (Name = Conforyon.Helper.Culture.Name, Override = Conforyon.Helper.Culture.Override) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperSetUICulture", Name, Override);
}

Conforyon.Helper.Culture.SetThread = function (Name = Conforyon.Helper.Culture.Name, Override = Conforyon.Helper.Culture.Override) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperSetThreadCulture", Name, Override);
}

Conforyon.Helper.Culture.SetThreadUi = function (Name = Conforyon.Helper.Culture.Name, Override = Conforyon.Helper.Culture.Override) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HelperSetThreadUICulture", Name, Override);
}



Conforyon.Board.Audio.CopyPath = function (Path) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyPath", Path);
}

Conforyon.Board.Audio.CopyByte = function (Bytes) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyByte", Bytes);
}

Conforyon.Board.Audio.PasteStream = function (Clear = Conforyon.Clear) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioPasteStream", Clear);
}


Conforyon.Board.Text.CopyInteger = function (Number) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyInteger", Number);
}

Conforyon.Board.Text.CopyLong = function (Number) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyLong", Number);
}

Conforyon.Board.Text.CopyDouble = function (Number) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyDouble", Number);
}

Conforyon.Board.Text.CopyFloat = function (Number) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyFloat", Number);
}

Conforyon.Board.Text.CopyObject = function (Value) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyObject", Value);
}

Conforyon.Board.Text.CopyText = function (Text) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextCopyText", Text);
}

Conforyon.Board.Text.PasteText = function (Clear = Conforyon.Clear, Back = Conforyon.Empty) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextPasteText", Clear, Back);
}



Conforyon.Color.Hex.RgbObject = function (Hex, Type = Conforyon.Color.Type, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorHexRgbObject", Hex, Type, Error);
}

Conforyon.Color.Hex.RgbText = function (Hex, Type = Conforyon.Color.Type, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorHexRgbText", Hex, Type, Error);
}


Conforyon.Color.Rgb.HexInteger = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexInteger", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexLong = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexLong", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexObject = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexObject", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexText = function (R, G, B, Sharp = Conforyon.Color.Sharp, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexText", R, G, B, Sharp, Error);
}



Conforyon.Cryptology.Aes.EncryptInteger = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptInteger", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptLong = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptLong", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptDouble = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptDouble", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptFloat = function (Number, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptFloat", Number, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptObject = function (Value, IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptObject", Value, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.EncryptText = function (Text, IV = IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesEncryptText", Text, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.DecryptObject = function (Base, IV = IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesDecryptObject", Base, IV, Key, Mode, Error);
}

Conforyon.Cryptology.Aes.DecryptText = function (Base, IV = IV = Conforyon.Cryptology.IV, Key = Conforyon.Cryptology.Key, Mode = Conforyon.Cryptology.Mode, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyAesDecryptText", Base, IV, Key, Mode, Error);
}


Conforyon.Cryptology.Base.DecryptObject = function (Base, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyBaseDecryptObject", Base, Error);
}

Conforyon.Cryptology.Base.DecryptText = function (Base, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyBaseDecryptText", Base, Error);
}


Conforyon.Cryptology.Text.Base.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Base.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextBaseEncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Md5.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Md5.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextMd5EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha1.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha1.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha1EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha256.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha256.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha256EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha384.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha384.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha384EncryptText", Text, Uppercase, Error);
}


Conforyon.Cryptology.Text.Sha512.EncryptInteger = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptInteger", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptLong = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptLong", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptDouble = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptDouble", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptFloat = function (Number, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptFloat", Number, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptObject = function (Value, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptObject", Value, Uppercase, Error);
}

Conforyon.Cryptology.Text.Sha512.EncryptText = function (Text, Uppercase = Conforyon.Cryptology.Uppercase, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "CryptologyTextSha512EncryptText", Text, Uppercase, Error);
}



Conforyon.Hash.File.Md5.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileMd5EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Md5.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileMd5EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha1.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha1EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha1.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha1EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha256.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha256EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha256.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha256EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha384.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha384EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha384.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha384EncryptText", Path, Uppercase, Error);
}


Conforyon.Hash.File.Sha512.EncryptObject = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha512EncryptObject", Path, Uppercase, Error);
}

Conforyon.Hash.File.Sha512.EncryptText = function (Path, Uppercase = Conforyon.Hash.Uppercase, Error = Conforyon.Error) {
    Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "HashFileSha512EncryptText", Path, Uppercase, Error);
}



Conforyon.Speed.Kph.Mph.ConvertInteger = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertInteger", Kilometers, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Kph.Mph.ConvertLong = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertLong", Kilometers, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Kph.Mph.ConvertObject = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertObject", Kilometers, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Kph.Mph.ConvertText = function (Kilometers, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedKphMphConvertText", Kilometers, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Speed.Mph.Kph.ConvertInteger = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertInteger", Miles, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Mph.Kph.ConvertLong = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertLong", Miles, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Mph.Kph.ConvertObject = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertObject", Miles, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Speed.Mph.Kph.ConvertText = function (Miles, Decimal, Comma, PostComma = Conforyon.Speed.PostComma, Text = Conforyon.Speed.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "SpeedMphKphConvertText", Miles, Decimal, Comma, PostComma, Text, Error);
}



Conforyon.Storage.Auto.ConvertInteger = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertInteger", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Auto.ConvertLong = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertLong", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Auto.ConvertObject = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertObject", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Auto.ConvertText = function (InputVariable, InputType, TypeText = Conforyon.Storage.TypeText, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageAutoConvertText", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}


Conforyon.Storage.Normal.ConvertInteger = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertInteger", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Normal.ConvertLong = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertLong", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Normal.ConvertObject = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertObject", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Storage.Normal.ConvertText = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Storage.Decimal, Comma = Conforyon.Storage.Comma, PostComma = Conforyon.Storage.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "StorageNormalConvertText", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}



Conforyon.Temperature.Kelvin.Celsius.ConvertInteger = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertInteger", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Celsius.ConvertLong = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertLong", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Celsius.ConvertObject = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertObject", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Celsius.ConvertText = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinCelsiusConvertText", Kelvin, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Kelvin.Fahrenheit.ConvertInteger = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertInteger", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Fahrenheit.ConvertLong = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertLong", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Fahrenheit.ConvertObject = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertObject", Kelvin, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Kelvin.Fahrenheit.ConvertText = function (Kelvin, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureKelvinFahrenheitConvertText", Kelvin, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Celsius.Kelvin.ConvertInteger = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertInteger", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Kelvin.ConvertLong = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertLong", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Kelvin.ConvertObject = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertObject", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Kelvin.ConvertText = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusKelvinConvertText", Celsius, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Celsius.Fahrenheit.ConvertInteger = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertInteger", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Fahrenheit.ConvertLong = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertLong", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Fahrenheit.ConvertObject = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertObject", Celsius, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Celsius.Fahrenheit.ConvertText = function (Celsius, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureCelsiusFahrenheitConvertText", Celsius, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Fahrenheit.Kelvin.ConvertInteger = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertInteger", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Kelvin.ConvertLong = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertLong", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Kelvin.ConvertObject = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertObject", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Kelvin.ConvertText = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitKelvinConvertText", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}


Conforyon.Temperature.Fahrenheit.Celsius.ConvertInteger = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertInteger", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Celsius.ConvertLong = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertLong", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Celsius.ConvertObject = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertObject", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}

Conforyon.Temperature.Fahrenheit.Celsius.ConvertText = function (Fahrenheit, Decimal, Comma, PostComma = Conforyon.Temperature.PostComma, Text = Conforyon.Temperature.Text, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TemperatureFahrenheitCelsiusConvertText", Fahrenheit, Decimal, Comma, PostComma, Text, Error);
}



Conforyon.Time.Auto.ConvertInteger = function (InputVariable, InputType, TypeText = Conforyon.Time.TypeText, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeAutoConvertInteger", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Time.Auto.ConvertLong = function (InputVariable, InputType, TypeText = Conforyon.Time.TypeText, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeAutoConvertLong", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Time.Auto.ConvertObject = function (InputVariable, InputType, TypeText = Conforyon.Time.TypeText, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeAutoConvertObject", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}

Conforyon.Time.Auto.ConvertText = function (InputVariable, InputType, TypeText = Conforyon.Time.TypeText, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeAutoConvertText", InputVariable, InputType, TypeText, Decimal, Comma, PostComma, Error);
}


Conforyon.Time.Normal.ConvertInteger = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeNormalConvertInteger", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Time.Normal.ConvertLong = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeNormalConvertLong", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Time.Normal.ConvertObject = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeNormalConvertObject", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}

Conforyon.Time.Normal.ConvertText = function (InputVariable, InputType, TypeConvert, Decimal = Conforyon.Time.Decimal, Comma = Conforyon.Time.Comma, PostComma = Conforyon.Time.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TimeNormalConvertText", InputVariable, InputType, TypeConvert, Decimal, Comma, PostComma, Error);
}



Conforyon.Typology.Cm.Px.ConvertInteger = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmPxConvertInteger", Centimeter, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Cm.Px.ConvertLong = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmPxConvertLong", Centimeter, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Cm.Px.ConvertObject = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmPxConvertObject", Centimeter, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Cm.Px.ConvertText = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmPxConvertText", Centimeter, Decimal, Comma, PostComma, Error);
}


Conforyon.Typology.Cm.Inch.ConvertInteger = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmInchConvertInteger", Centimeter, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Cm.Inch.ConvertLong = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmInchConvertLong", Centimeter, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Cm.Inch.ConvertObject = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmInchConvertObject", Centimeter, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Cm.Inch.ConvertText = function (Centimeter, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyCmInchConvertText", Centimeter, Decimal, Comma, PostComma, Error);
}


Conforyon.Typology.Px.Cm.ConvertInteger = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxCmConvertInteger", Pixel, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Px.Cm.ConvertLong = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxCmConvertLong", Pixel, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Px.Cm.ConvertObject = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxCmConvertObject", Pixel, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Px.Cm.ConvertText = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxCmConvertText", Pixel, Decimal, Comma, PostComma, Error);
}


Conforyon.Typology.Px.Inch.ConvertInteger = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxInchConvertInteger", Pixel, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Px.Inch.ConvertLong = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxInchConvertLong", Pixel, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Px.Inch.ConvertObject = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxInchConvertObject", Pixel, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Px.Inch.ConvertText = function (Pixel, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyPxInchConvertText", Pixel, Decimal, Comma, PostComma, Error);
}


Conforyon.Typology.Inch.Cm.ConvertInteger = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchCmConvertInteger", Inch, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Inch.Cm.ConvertLong = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchCmConvertLong", Inch, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Inch.Cm.ConvertObject = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchCmConvertObject", Inch, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Inch.Cm.ConvertText = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchCmConvertText", Inch, Decimal, Comma, PostComma, Error);
}


Conforyon.Typology.Inch.Px.ConvertInteger = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchPxConvertInteger", Inch, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Inch.Px.ConvertLong = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchPxConvertLong", Inch, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Inch.Px.ConvertObject = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchPxConvertObject", Inch, Decimal, Comma, PostComma, Error);
}

Conforyon.Typology.Inch.Px.ConvertText = function (Inch, Decimal, Comma, PostComma = Conforyon.Typology.PostComma, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "TypologyInchPxConvertText", Inch, Decimal, Comma, PostComma, Error);
}



Conforyon.Unicode.Ascii.CharInteger = function (Ascii, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeAsciiCharInteger", Ascii, Bracket, Error);
}

Conforyon.Unicode.Ascii.CharLong = function (Ascii, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeAsciiCharLong", Ascii, Bracket, Error);
}

Conforyon.Unicode.Ascii.CharDouble = function (Ascii, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeAsciiCharDouble", Ascii, Bracket, Error);
}

Conforyon.Unicode.Ascii.CharFloat = function (Ascii, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeAsciiCharFloat", Ascii, Bracket, Error);
}

Conforyon.Unicode.Ascii.CharChar = function (Ascii, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeAsciiCharChar", Ascii, Bracket, Error);
}

Conforyon.Unicode.Ascii.CharObject = function (Ascii, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeAsciiCharObject", Ascii, Bracket, Error);
}

Conforyon.Unicode.Ascii.CharText = function (Ascii, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeAsciiCharText", Ascii, Bracket, Error);
}


Conforyon.Unicode.Char.AsciiInteger = function (Char, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeCharAsciiInteger", Char, Bracket, Error);
}

Conforyon.Unicode.Char.AsciiLong = function (Char, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeCharAsciiLong", Char, Bracket, Error);
}

Conforyon.Unicode.Char.AsciiDouble = function (Char, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeCharAsciiDouble", Char, Bracket, Error);
}

Conforyon.Unicode.Char.AsciiFloat = function (Char, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeCharAsciiFloat", Char, Bracket, Error);
}

Conforyon.Unicode.Char.AsciiChar = function (Char, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeCharAsciiChar", Char, Bracket, Error);
}

Conforyon.Unicode.Char.AsciiObject = function (Char, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeCharAsciiObject", Char, Bracket, Error);
}

Conforyon.Unicode.Char.AsciiText = function (Char, Bracket = Conforyon.Unicode.Bracket, Error = Conforyon.Error) {
    return Taiizor.Invoke.MethodAsync("Taiizor.Essentials.Maui.Conforyon", "UnicodeCharAsciiText", Char, Bracket, Error);
}