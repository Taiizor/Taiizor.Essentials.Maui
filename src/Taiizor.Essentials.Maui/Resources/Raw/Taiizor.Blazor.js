console.log('%cTaiizor Blazor Javascript has started.', 'color: #DC143C');


var Taiizor = {};


Taiizor.Storage = {};
Taiizor.Storage.Local = {};
Taiizor.Storage.Session = {};


Taiizor.Add = {};
Taiizor.Add.Script = {};


Taiizor.Attribute = {};


Taiizor.Class = {};


Taiizor.Cookie = {};


Taiizor.Include = {};


Taiizor.Invoke = {};
Taiizor.Invoke.Reference = {};


Taiizor.Lang = {};
Taiizor.Lang.Tag = {};
Taiizor.Lang.Html = {};
Taiizor.Lang.Head = {};
Taiizor.Lang.Body = {};


Taiizor.Location = {};
Taiizor.Location.Href = {};
Taiizor.Location.Host = {};
Taiizor.Location.Port = {};
Taiizor.Location.Hash = {};
Taiizor.Location.Origin = {};
Taiizor.Location.Search = {};
Taiizor.Location.Pathname = {};
Taiizor.Location.Hostname = {};
Taiizor.Location.Protocol = {};


Taiizor.Redirect = {};


Taiizor.Reload = {};


Taiizor.Style = {};
Taiizor.Style.Styles = [];


Taiizor.Title = {};



Taiizor.Storage.Session.Set = function (sessionKey, sessionValue) {
    sessionStorage.setItem(sessionKey, sessionValue);
}

Taiizor.Storage.Session.Get = function (sessionKey) {
    return sessionStorage.getItem(sessionKey);
}

Taiizor.Storage.Session.Check = function (sessionKey) {
    let sessionValue = Taiizor.Storage.Session.Get(sessionKey);
    if (sessionValue == null || sessionValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.Storage.Session.Delete = function (sessionKey, execute = false) {
    if (Taiizor.Storage.Session.Check(sessionKey) || execute) {
        sessionStorage.removeItem(sessionKey);
    }
}



Taiizor.Storage.Local.Set = function (localKey, localValue) {
    localStorage.setItem(localKey, localValue);
}

Taiizor.Storage.Local.Get = function (localKey) {
    return localStorage.getItem(localKey);
}

Taiizor.Storage.Local.Check = function (localKey) {
    let localValue = Taiizor.Storage.Local.Get(localKey);
    if (localValue == null || localValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.Storage.Local.Delete = function (localKey, execute = false) {
    if (Taiizor.Storage.Local.Check(localKey) || execute) {
        localStorage.removeItem(localKey);
    }
}



Taiizor.Add.Head = function (tagHtml) {
    document.head.appendChild(document.createRange().createContextualFragment(tagHtml));
}

Taiizor.Add.Body = function (tagHtml) {
    document.body.appendChild(document.createRange().createContextualFragment(tagHtml));
}

Taiizor.Add.Script.Head = function (textNode) {
    var element = document.createElement('script');
    element.setAttribute('type', 'text/javascript');

    element.appendChild(document.createTextNode(textNode));
    document.head.appendChild(element);
}

Taiizor.Add.Script.Body = function (textNode) {
    var element = document.createElement('script');
    element.setAttribute('type', 'text/javascript');

    element.appendChild(document.createTextNode(textNode));
    document.body.appendChild(element);
}



Taiizor.Attribute.Set = function (elementId, propertyName, propertyValue) {
    document.getElementById(elementId).setAttribute(propertyName, propertyValue);
}

Taiizor.Attribute.Remove = function (elementId, propertyName) {
    document.getElementById(elementId).removeAttribute(propertyName);
}



Taiizor.Class.Set = function (classId, className) {
    document.getElementById(classId).className = className;
}

Taiizor.Class.Add = function (classId, className) {
    document.getElementById(classId).classList.add(className);
}

Taiizor.Class.Toggle = function (classId, className) {
    document.getElementById(classId).classList.toggle(className);
}

Taiizor.Class.Remove = function (classId, className) {

    document.getElementById(classId).classList.remove(className);
}



Taiizor.Cookie.Set = function (cookieName, cookieValue, exDays, path) {
    const d = new Date();
    d.setTime(d.getTime() + (exDays * 24 * 60 * 60 * 1000));
    let expires = 'expires=' + d.toUTCString();
    let paths = 'path=' + path;
    document.cookie = cookieName + '=' + cookieValue + ';' + expires + ';' + paths;
}

Taiizor.Cookie.Get = function (cookieName) {
    let name = cookieName + '=';
    let ca = document.cookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }

    return '';
}

Taiizor.Cookie.Check = function (cookieName) {
    let cookieValue = Taiizor.Cookie.Get(cookieName);
    if (cookieValue == null || cookieValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.Cookie.Delete = function (cookieName, execute = false) {
    if (Taiizor.Cookie.Check(cookieName) || execute) {
        document.cookie = cookieName + '=; Max-Age=-99999999;';
    }
}



Taiizor.Include.Font = function (path, rel) {
    var customFont = document.createElement('link');
    customFont.setAttribute('href', path);
    customFont.setAttribute('rel', rel);
    document.head.appendChild(customFont);
}

Taiizor.Include.Js = function (path) {
    var customScript = document.createElement('script');
    customScript.setAttribute('src', path);
    document.body.appendChild(customScript);
}

Taiizor.Include.Css = function (path, rel, type) {
    var customStylesheet = document.createElement('link');
    customStylesheet.setAttribute('href', path);
    customStylesheet.setAttribute('rel', rel);
    customStylesheet.setAttribute('type', type);
    document.head.appendChild(customStylesheet);
}



Taiizor.Invoke.MethodAsync = function (assemblyName, methodName, ...args) {
    if (arguments != null && arguments.length > 0) {
        return DotNet.invokeMethodAsync(assemblyName, methodName, ...args);
    } else {
        return DotNet.invokeMethodAsync(assemblyName, methodName);
    }
}

Taiizor.Invoke.Reference.MethodAsync = function (objectReference, methodName, ...args) {
    if (arguments != null && arguments.length > 0) {
        return objectReference.invokeMethodAsync(methodName, ...args);
    } else {
        return objectReference.invokeMethodAsync(methodName);
    }

    //objectReference.dispose();
}



Taiizor.Lang.Html.Set = function (languageCode) {
    document.documentElement.lang = languageCode;
}

Taiizor.Lang.Html.Get = function () {
    return document.documentElement.lang;
}

Taiizor.Lang.Html.Check = function () {
    let langValue = Taiizor.Lang.Html.Get();
    if (langValue == null || langValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.Lang.Head.Set = function (languageCode) {
    document.head.lang = languageCode;
}

Taiizor.Lang.Head.Get = function () {
    return document.head.lang;
}

Taiizor.Lang.Head.Check = function () {
    let langValue = Taiizor.Lang.Head.Get();
    if (langValue == null || langValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.Lang.Body.Get = function (languageCode) {
    document.body.lang = languageCode;
}

Taiizor.Lang.Body.Get = function () {
    return document.body.lang;
}

Taiizor.Lang.Body.Check = function () {
    let langValue = Taiizor.Lang.Body.Get();
    if (langValue == null || langValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.Lang.Tag.Set = function (tagHtml, languageCode) {
    document.getElementById(tagHtml).lang = languageCode;
}

Taiizor.Lang.Tag.Get = function (tagHtml) {
    try {
        return document.getElementById(tagHtml).lang;
    } catch {
        return '';
    }
}

Taiizor.Lang.Tag.Check = function (tagHtml) {
    let langValue = Taiizor.Lang.Tag.Get(tagHtml);
    if (langValue == null || langValue == '') {
        return false;
    } else {
        return true;
    }
}



Taiizor.Location.Href.Set = function (href = '') {
    window.location.href = href;
}

Taiizor.Location.Href.Get = function () {
    return window.location.href;
}

Taiizor.Location.Host.Set = function (host = '') {
    window.location.host = host;
}

Taiizor.Location.Host.Get = function () {
    return window.location.host;
}

Taiizor.Location.Hostname.Set = function (hostname = '') {
    window.location.hostname = hostname;
}

Taiizor.Location.Hostname.Get = function () {
    return window.location.hostname;
}

Taiizor.Location.Origin.Set = function (origin = '') {
    window.location.origin = origin;
}

Taiizor.Location.Origin.Get = function () {
    return window.location.origin;
}

Taiizor.Location.Pathname.Set = function (pathname = '') {
    window.location.pathname = pathname;
}

Taiizor.Location.Pathname.Get = function () {
    return window.location.pathname;
}

Taiizor.Location.Port.Set = function (port = '443') {
    window.location.port = port;
}

Taiizor.Location.Port.Get = function () {
    return window.location.port;
}

Taiizor.Location.Protocol.Set = function (protocol = 'https:') {
    window.location.protocol = protocol;
}

Taiizor.Location.Protocol.Get = function () {
    return window.location.protocol;
}

Taiizor.Location.Search.Set = function (search = '') {
    window.location.search = search;
}

Taiizor.Location.Search.Get = function () {
    return window.location.search;
}

Taiizor.Location.Hash.Set = function (hash = '') {
    window.location.hash = hash;
}

Taiizor.Location.Hash.Get = function () {
    return window.location.hash;
}



Taiizor.Redirect.Location = function (uri = '/') {
    location.href = uri;
    //window.location.href = uri;
}



Taiizor.Reload.Page = function () {
    window.location.reload();
}

Taiizor.Reload.Element = function (elementId, methodType) {
    if (methodType === true) {
        var container = document.getElementById(elementId);
        var content = container.innerHTML;
        container.innerHTML = content;
    } else {
        document.getElementById(elementId).innerHTML = document.getElementById(elementId).innerHTML;
    }
}



Taiizor.Style.Set = function (styleId, stylePair) {
    document.getElementById(styleId).style = stylePair;
}

Taiizor.Style.Add = function (styleId, styleName, styleValue) {
    document.getElementById(styleId).style.setProperty(styleName, styleValue);
}

Taiizor.Style.Toggle = function (styleId) {
    var style = document.getElementById(styleId).style.cssText;

    if (style != '') {
        Taiizor.Style.Styles[styleId] = document.getElementById(styleId).style.cssText;
        document.getElementById(styleId).style.cssText = null;
    } else if (Taiizor.Style.Styles[styleId] != null) {
        document.getElementById(styleId).style.cssText = Taiizor.Style.Styles[styleId];
        Taiizor.Style.Styles[styleId] = null;
    }
}

Taiizor.Style.Remove = function (styleId, styleName) {
    document.getElementById(styleId).style.removeProperty(styleName);
}



Taiizor.Title.Set = function (title) {
    document.title = title;
}

Taiizor.Title.Get = function () {
    return document.title;
}

Taiizor.Title.Check = function () {
    let titleValue = Taiizor.Title.Get();
    if (titleValue == null || titleValue == '') {
        return true;
    }
    else {
        return false;
    }
}