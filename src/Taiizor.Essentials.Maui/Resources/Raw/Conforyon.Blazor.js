console.log('%cConforyon Blazor Javascript has started.', 'color: #FFC000');

var Conforyon = {};

Conforyon.Board.Audio.CopyPath = function (Path) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyPath", Path);
}

Conforyon.Board.Audio.CopyByte = function (Bytes) {
    Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioCopyByte", Bytes);
}

Conforyon.Board.Audio.PasteStream = function (Clear = false) {
    return Taiizor.InvokeMethodAsync("Taiizor.Essentials.Maui.Conforyon", "BoardAudioPasteStream", Clear);
}