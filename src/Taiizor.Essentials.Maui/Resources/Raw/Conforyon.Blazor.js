console.log('%cConforyon Blazor Javascript has started.', 'color: #FFC000');

var Conforyon = {};

Conforyon.Board.Audio.CopyPath = function (Path) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyPath", Path);
}

Conforyon.Board.Audio.CopyByte = function (Bytes) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyByte", Bytes);
}

Conforyon.Board.Audio.PasteStream = function (Clear = false, Empty = "Empty!") {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioPasteStream", Clear, Empty);
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

Conforyon.Board.Text.PasteText = function (Clear = false) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardTextPasteText", Clear);
}



Conforyon.Color.Hex.RgbObject = function (Hex, Type = "RGB1", Error = "Error!") {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorHexRgbObject", Hex, Type, Error);
}

Conforyon.Color.Hex.RgbText = function (Hex, Type = "RGB1", Error = "Error!") {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorHexRgbText", Hex, Type, Error);
}


Conforyon.Color.Rgb.HexInteger = function (R, G, B, Sharp = false, Error = "Error!") {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexInteger", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexLong = function (R, G, B, Sharp = false, Error = "Error!") {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexLong", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexObject = function (R, G, B, Sharp = false, Error = "Error!") {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexObject", R, G, B, Sharp, Error);
}

Conforyon.Color.Rgb.HexText = function (R, G, B, Sharp = false, Error = "Error!") {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "ColorRgbHexText", R, G, B, Sharp, Error);
}