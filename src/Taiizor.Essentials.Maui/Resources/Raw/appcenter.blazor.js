console.log('%cAppCenter Blazor Javascript has started.', 'color: #1E90FF');

var AppCenter = {};

AppCenter.TrackEventBasic = function(Name) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackEventBasic", Name);
}

AppCenter.TrackEventNormal = function(Name, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackEventNormal", Name, Key, Value);
}

AppCenter.TrackEventAdvanced = function(Name, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackEventAdvanced", Name, Properties);
}


AppCenter.WatchEventBasic = function(Name) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchEventBasic", Name);
}

AppCenter.WatchEventNormal = function(Name, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchEventNormal", Name, Key, Value);
}

AppCenter.WatchEventAdvanced = function(Name, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchEventAdvanced", Name, Properties);
}



AppCenter.TrackErrorBasic = function(Exception) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorBasic", Exception);
}

AppCenter.TrackErrorNormal = function(Exception, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorNormal", Exception, Key, Value);
}

AppCenter.TrackErrorAdvanced = function(Exception, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorAdvanced", Exception, Properties);
}

AppCenter.TrackErrorHard = function(Exception, Properties, Text, TextFile, Image, ImageFile, Extension) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorHard", Exception, Properties, Text, TextFile, Image, ImageFile, Extension);
}

AppCenter.TrackErrorExpert = function(Exception, Properties, Text, TextFile, Image, ImageFile, Extension) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorExpert", Exception, Properties, Text, TextFile, Image, ImageFile, Extension);
}

AppCenter.TrackErrorGod = function(Exception, Properties, Attachments) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorGod", Exception, Properties, Attachments);
}


AppCenter.WatchErrorBaby = function(Name) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorBaby", Name);
}

AppCenter.WatchErrorBasic = function(Exception) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorBasic", Exception);
}

AppCenter.WatchErrorNormal = function(Exception, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorNormal", Exception, Key, Value);
}

AppCenter.WatchErrorAdvanced = function(Exception, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorAdvanced", Exception, Properties);
}

AppCenter.WatchErrorHard = function(Exception, Properties, Attachments) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorHard", Exception, Properties, Attachments);
}