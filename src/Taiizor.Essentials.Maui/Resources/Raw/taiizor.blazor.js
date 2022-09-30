console.log('%cTaiizor Blazor Javascript has started.', 'color: #DC143C');

var Taiizor = {};

Taiizor.Reload = function() {
    window.location.reload();
}

Taiizor.GoLocation = function(uriLocation = '/') {
    location.href = uriLocation;
    //window.location.href = uriLocation;
}

Taiizor.ReloadElement = function(elementId, methodType) {
    if (methodType === true) {
        var container = document.getElementById(elementId);
        var content = container.innerHTML;
        container.innerHTML = content;
    } else {
        document.getElementById(elementId).innerHTML = document.getElementById(elementId).innerHTML;
    }
}

Taiizor.IncludeFont = function(path, rel) {
    var customFont = document.createElement('link');
    customFont.setAttribute('href', path);
    customFont.setAttribute('rel', rel);
    document.head.appendChild(customFont);
}

Taiizor.IncludeJs = function(path) {
    var customScript = document.createElement('script');
    customScript.setAttribute('src', path);
    document.body.appendChild(customScript);
}

Taiizor.IncludeCss = function(path, rel, type) {
    var customStylesheet = document.createElement('link');
    customStylesheet.setAttribute('href', path);
    customStylesheet.setAttribute('rel', rel);
    customStylesheet.setAttribute('type', type);
    document.head.appendChild(customStylesheet);
}

Taiizor.SetAttribute = function(elementId, propertyName, propertyValue) {
    document.getElementById(elementId).setAttribute(propertyName, propertyValue);
}

Taiizor.RemoveAttribute = function(elementId, propertyName) {
    document.getElementById(elementId).removeAttribute(propertyName);
}

Taiizor.SetClass = function(classId, className) {
    document.getElementById(classId).className = className;
}

Taiizor.AddClass = function(classId, className) {
    document.getElementById(classId).classList.add(className);
}

Taiizor.ToggleClass = function(classId, className) {
    document.getElementById(classId).classList.toggle(className);
}

Taiizor.RemoveClass = function(classId, className) {

    document.getElementById(classId).classList.remove(className);
}

Taiizor.SetStyle = function(styleId, stylePair) {
    document.getElementById(styleId).style = stylePair;
}

Taiizor.AddStyle = function(styleId, styleName, styleValue) {
    document.getElementById(styleId).style.setProperty(styleName, styleValue);
}

Taiizor.styles = [];

Taiizor.ToggleStyle = function(styleId) {
    var style = document.getElementById(styleId).style.cssText;

    if (style != '') {
        Taiizor.styles[styleId] = document.getElementById(styleId).style.cssText;
        document.getElementById(styleId).style.cssText = null;
    } else if (Taiizor.styles[styleId] != null) {
        document.getElementById(styleId).style.cssText = Taiizor.styles[styleId];
        Taiizor.styles[styleId] = null;
    }
}

Taiizor.RemoveStyle = function(styleId, styleName) {
    document.getElementById(styleId).style.removeProperty(styleName);
}

Taiizor.HeadAdd = function(tagHtml) {
    document.head.appendChild(document.createRange().createContextualFragment(tagHtml));
}

Taiizor.BodyAdd = function(tagHtml) {
    document.body.appendChild(document.createRange().createContextualFragment(tagHtml));
}

Taiizor.HeadScriptAdd = function(textNode) {
    var element = document.createElement('script');
    element.setAttribute('type', 'text/javascript');

    element.appendChild(document.createTextNode(textNode));
    document.head.appendChild(element);
}

Taiizor.BodyScriptAdd = function(textNode) {
    var element = document.createElement('script');
    element.setAttribute('type', 'text/javascript');

    element.appendChild(document.createTextNode(textNode));
    document.body.appendChild(element);
}

Taiizor.SetCookie = function(cookieName, cookieValue, exDays, path) {
    const d = new Date();
    d.setTime(d.getTime() + (exDays * 24 * 60 * 60 * 1000));
    let expires = 'expires=' + d.toUTCString();
    let paths = 'path=' + path;
    document.cookie = cookieName + '=' + cookieValue + ';' + expires + ';' + paths;
}

Taiizor.GetCookie = function(cookieName) {
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

Taiizor.CheckCookie = function(cookieName) {
    let cookieValue = GetCookie(cookieName);
    if (cookieValue == null || cookieValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.DeleteCookie = function(cookieName, execute = false) {
    if (CheckCookie(cookieName) || execute) {
        document.cookie = cookieName + '=; Max-Age=-99999999;'; 
    }
}

Taiizor.SetLocalStorage = function(localKey, localValue) {
    localStorage.setItem(localKey, localValue);
}

Taiizor.GetLocalStorage = function(localKey) {
    return localStorage.getItem(localKey);
}

Taiizor.CheckLocalStorage = function(localKey) {
    let localValue = GetLocalStorage(localKey);
    if (localValue == null || localValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.DeleteLocalStorage = function(localKey, execute = false) {
    if (CheckLocalStorage(localKey) || execute) {
        localStorage.removeItem(localKey);
    }
}

Taiizor.SetSessionStorage = function(sessionKey, sessionValue) {
    sessionStorage.setItem(sessionKey, sessionValue);
}

Taiizor.GetSessionStorage = function(sessionKey) {
    return sessionStorage.getItem(sessionKey);
}

Taiizor.CheckSessionStorage = function(sessionKey) {
    let sessionValue = GetSessionStorage(sessionKey);
    if (sessionValue == null || sessionValue == '') {
        return false;
    } else {
        return true;
    }
}

Taiizor.DeleteSessionStorage = function(sessionKey, execute = false) {
    if (CheckSessionStorage(sessionKey) || execute) {
        sessionStorage.removeItem(sessionKey);
    }
}

Taiizor.SetLangHtml = function(languageCode) {
    document.documentElement.lang = languageCode;
}

Taiizor.GetLangHtml = function() {
    return document.documentElement.lang;
}

Taiizor.SetLangHead = function(languageCode) {
    document.head.lang = languageCode;
}

Taiizor.GetLangHead = function() {
    return document.head.lang;
}

Taiizor.SetLangBody = function(languageCode) {
    document.body.lang = languageCode;
}

Taiizor.GetLangBody = function() {
    return document.body.lang;
}

Taiizor.SetLang = function(tagHtml, languageCode) {
    document.getElementById(tagHtml).lang = languageCode;
}

Taiizor.GetLang = function(tagHtml) {
    try {
        return document.getElementById(tagHtml).lang;
    } catch {
        return '';
    }
}

Taiizor.CheckLang = function(tagHtml) {
    try {
        let langValue = document.getElementById(tagHtml).lang;
        if (langValue == null || langValue == '') {
            return false;
        } else {
            return true;
        }
    } catch {
        return false;
    }
}

Taiizor.SetTitle = function(title) {
    document.title = title;
}

Taiizor.GetTitle = function() {
    return document.title;
}

Taiizor.CheckTitle = function() {
    let titleValue = document.title;
    if (titleValue == null || titleValue == '') {
        return true;
    }
    else {
        return false;
    }
}

Taiizor.InvokeMethodAsync = function(assemblyName, methodName, ...args) {
    if (arguments != null && arguments.length > 0) {
        return DotNet.invokeMethodAsync(assemblyName, methodName, ...args);
    } else {
        return DotNet.invokeMethodAsync(assemblyName, methodName);
    }
}

Taiizor.InvokeReferenceMethodAsync = function(objectReference, methodName, ...args) {
    if (arguments != null && arguments.length > 0) {
        return objectReference.invokeMethodAsync(methodName, ...args);
    } else {
        return objectReference.invokeMethodAsync(methodName);
    }

    //objectReference.dispose();
}