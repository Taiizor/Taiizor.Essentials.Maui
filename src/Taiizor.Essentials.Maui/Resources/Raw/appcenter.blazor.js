console.log('%cAppCenter Blazor Javascript has started.', 'color: #1E90FF');

function TrackEventBasic(Name) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackEventBasic", Name);
}

function TrackEventNormal(Name, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackEventNormal", Name, Key, Value);
}

function TrackEventAdvanced(Name, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackEventAdvanced", Name, Properties);
}


function WatchEventBasic(Name) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchEventBasic", Name);
}

function WatchEventNormal(Name, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchEventNormal", Name, Key, Value);
}

function WatchEventAdvanced(Name, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchEventAdvanced", Name, Properties);
}



function TrackErrorBasic(Exception) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorBasic", Exception);
}

function TrackErrorNormal(Exception, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorNormal", Exception, Key, Value);
}

function TrackErrorAdvanced(Exception, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorAdvanced", Exception, Properties);
}

function TrackErrorHard(Exception, Properties, Text, TextFile, Image, ImageFile, Extension) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorHard", Exception, Properties, Text, TextFile, Image, ImageFile, Extension);
}

function TrackErrorExpert(Exception, Properties, Text, TextFile, Image, ImageFile, Extension) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorExpert", Exception, Properties, Text, TextFile, Image, ImageFile, Extension);
}

function TrackErrorGod(Exception, Properties, Attachments) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "TrackErrorGod", Exception, Properties, Attachments);
}


function WatchErrorBaby(Name) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorBaby", Name);
}

function WatchErrorBasic(Exception) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorBasic", Exception);
}

function WatchErrorNormal(Exception, Key, Value) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorNormal", Exception, Key, Value);
}

function WatchErrorAdvanced(Exception, Properties) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorAdvanced", Exception, Properties);
}

function WatchErrorHard(Exception, Properties, Attachments) {
    InvokeMethodAsync("Taiizor.Essentials.Maui.AppCenter", "WatchErrorHard", Exception, Properties, Attachments);
}