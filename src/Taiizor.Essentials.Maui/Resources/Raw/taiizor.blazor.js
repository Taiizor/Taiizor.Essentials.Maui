console.log('%cTaiizor Blazor Javascript has started.', 'color: #DC143C');

var Taiizor = {};

function Reload() {
    window.location.reload();
}

function GoLocation(uriLocation = '/') {
    location.href = uriLocation;
    //window.location.href = uriLocation;
}

function ReloadElement(elementId, methodType) {
    if (methodType === true) {
        var container = document.getElementById(elementId);
        var content = container.innerHTML;
        container.innerHTML = content;
    } else {
        document.getElementById(elementId).innerHTML = document.getElementById(elementId).innerHTML;
    }
}

function IncludeFont(path, rel) {
    var customFont = document.createElement('link');
    customFont.setAttribute('href', path);
    customFont.setAttribute('rel', rel);
    document.head.appendChild(customFont);
}

function IncludeJs(path) {
    var customScript = document.createElement('script');
    customScript.setAttribute('src', path);
    document.body.appendChild(customScript);
}

function IncludeCss(path, rel, type) {
    var customStylesheet = document.createElement('link');
    customStylesheet.setAttribute('href', path);
    customStylesheet.setAttribute('rel', rel);
    customStylesheet.setAttribute('type', type);
    document.head.appendChild(customStylesheet);
}

function SetAttribute(elementId, propertyName, propertyValue) {
    document.getElementById(elementId).setAttribute(propertyName, propertyValue);
}

function RemoveAttribute(elementId, propertyName) {
    document.getElementById(elementId).removeAttribute(propertyName);
}

function SetClass(classId, className) {
    document.getElementById(classId).className = className;
}

function AddClass(classId, className) {
    document.getElementById(classId).classList.add(className);
}

function ToggleClass(classId, className) {
    document.getElementById(classId).classList.toggle(className);
}

function RemoveClass(classId, className) {

    document.getElementById(classId).classList.remove(className);
}

function SetStyle(styleId, stylePair) {
    document.getElementById(styleId).style = stylePair;
}

function AddStyle(styleId, styleName, styleValue) {
    document.getElementById(styleId).style.setProperty(styleName, styleValue);
}

var styles = [];

function ToggleStyle(styleId) {
    var style = document.getElementById(styleId).style.cssText;

    if (style != '') {
        styles[styleId] = document.getElementById(styleId).style.cssText;
        document.getElementById(styleId).style.cssText = null;
    } else if (styles[styleId] != null) {
        document.getElementById(styleId).style.cssText = styles[styleId];
        styles[styleId] = null;
    }
}

function RemoveStyle(styleId, styleName) {
    document.getElementById(styleId).style.removeProperty(styleName);
}

function HeadAdd(tagHtml) {
    document.head.appendChild(document.createRange().createContextualFragment(tagHtml));
}

function BodyAdd(tagHtml) {
    document.body.appendChild(document.createRange().createContextualFragment(tagHtml));
}

function HeadScriptAdd(textNode) {
    var element = document.createElement('script');
    element.setAttribute('type', 'text/javascript');

    element.appendChild(document.createTextNode(textNode));
    document.head.appendChild(element);
}

function BodyScriptAdd(textNode) {
    var element = document.createElement('script');
    element.setAttribute('type', 'text/javascript');

    element.appendChild(document.createTextNode(textNode));
    document.body.appendChild(element);
}

function SetCookie(cookieName, cookieValue, exDays, path) {
    const d = new Date();
    d.setTime(d.getTime() + (exDays * 24 * 60 * 60 * 1000));
    let expires = 'expires=' + d.toUTCString();
    let paths = 'path=' + path;
    document.cookie = cookieName + '=' + cookieValue + ';' + expires + ';' + paths;
}

function GetCookie(cookieName) {
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

function CheckCookie(cookieName) {
    let cookieValue = GetCookie(cookieName);
    if (cookieValue == null || cookieValue == '') {
        return false;
    } else {
        return true;
    }
}

function DeleteCookie(cookieName, execute = false) {
    if (CheckCookie(cookieName) || execute) {
        document.cookie = cookieName + '=; Max-Age=-99999999;'; 
    }
}

function SetLocalStorage(localKey, localValue) {
    localStorage.setItem(localKey, localValue);
}

function GetLocalStorage(localKey) {
    return localStorage.getItem(localKey);
}

function CheckLocalStorage(localKey) {
    let localValue = GetLocalStorage(localKey);
    if (localValue == null || localValue == '') {
        return false;
    } else {
        return true;
    }
}

function DeleteLocalStorage(localKey, execute = false) {
    if (CheckLocalStorage(localKey) || execute) {
        localStorage.removeItem(localKey);
    }
}

function SetSessionStorage(sessionKey, sessionValue) {
    sessionStorage.setItem(sessionKey, sessionValue);
}

function GetSessionStorage(sessionKey) {
    return sessionStorage.getItem(sessionKey);
}

function CheckSessionStorage(sessionKey) {
    let sessionValue = GetSessionStorage(sessionKey);
    if (sessionValue == null || sessionValue == '') {
        return false;
    } else {
        return true;
    }
}

function DeleteSessionStorage(sessionKey, execute = false) {
    if (CheckSessionStorage(sessionKey) || execute) {
        sessionStorage.removeItem(sessionKey);
    }
}

function SetLangHtml(languageCode) {
    document.documentElement.lang = languageCode;
}

function GetLangHtml() {
    return document.documentElement.lang;
}

function SetLangHead(languageCode) {
    document.head.lang = languageCode;
}

function GetLangHead() {
    return document.head.lang;
}

function SetLangBody(languageCode) {
    document.body.lang = languageCode;
}

function GetLangBody() {
    return document.body.lang;
}

function SetLang(tagHtml, languageCode) {
    document.getElementById(tagHtml).lang = languageCode;
}

function GetLang(tagHtml) {
    try {
        return document.getElementById(tagHtml).lang;
    } catch {
        return '';
    }
}

function CheckLang(tagHtml) {
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

function SetTitle(title) {
    document.title = title;
}

function GetTitle() {
    return document.title;
}

function CheckTitle() {
    let titleValue = document.title;
    if (titleValue == null || titleValue == '') {
        return true;
    }
    else {
        return false;
    }
}

function InvokeMethodAsync(assemblyName, methodName, ...args) {
    if (arguments != null && arguments.length > 0) {
        return DotNet.invokeMethodAsync(assemblyName, methodName, ...args);
    } else {
        return DotNet.invokeMethodAsync(assemblyName, methodName);
    }
}

function InvokeReferenceMethodAsync(objectReference, methodName, ...args) {
    if (arguments != null && arguments.length > 0) {
        return objectReference.invokeMethodAsync(methodName, ...args);
    } else {
        return objectReference.invokeMethodAsync(methodName);
    }

    //objectReference.dispose();
}