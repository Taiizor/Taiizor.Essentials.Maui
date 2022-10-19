using Microsoft.JSInterop;
using Taiizor.Essentials.Maui.Conforyon.Value;
using CCC = Conforyon.Culture.Cultures;

namespace Taiizor.Essentials.Maui.Conforyon.Helper
{
    public class Culture
    {
        [JSInvokable("HelperGetCultureName")]
        //[JSInvokableAttribute("HelperGetCultureName")]
        public static string GetCultureName(string Error = Internal.Error)
        {
            return CCC.GetCultureName(Error);
        }

        [JSInvokable("HelperGetUICultureName")]
        //[JSInvokableAttribute("HelperGetUICultureName")]
        public static string GetUICultureName(string Error = Internal.Error)
        {
            return CCC.GetUICultureName(Error);
        }

        [JSInvokable("HelperGetThreadCultureName")]
        //[JSInvokableAttribute("HelperGetThreadCultureName")]
        public static string GetThreadCultureName(string Error = Internal.Error)
        {
            return CCC.GetThreadCultureName(Error);
        }

        [JSInvokable("HelperGetThreadUICultureName")]
        //[JSInvokableAttribute("HelperGetThreadUICultureName")]
        public static string GetThreadUICultureName(string Error = Internal.Error)
        {
            return CCC.GetThreadUICultureName(Error);
        }

        [JSInvokable("HelperSetCulture")]
        //[JSInvokableAttribute("HelperSetCulture")]
        public static bool SetCulture(string Name = Internal.CultureName, bool Override = Internal.CultureOverride)
        {
            return CCC.SetCulture(Name, Override);
        }

        [JSInvokable("HelperSetAllCulture")]
        //[JSInvokableAttribute("HelperSetAllCulture")]
        public static bool SetAllCulture(string Name = Internal.CultureName, bool Override = Internal.CultureOverride)
        {
            return CCC.SetAllCulture(Name, Override);
        }

        [JSInvokable("HelperSetUICulture")]
        //[JSInvokableAttribute("HelperSetUICulture")]
        public static bool SetUICulture(string Name = Internal.CultureName, bool Override = Internal.CultureOverride)
        {
            return CCC.SetUICulture(Name, Override);
        }

        [JSInvokable("HelperSetThreadCulture")]
        //[JSInvokableAttribute("HelperSetThreadCulture")]
        public static bool SetThreadCulture(string Name = Internal.CultureName, bool Override = Internal.CultureOverride)
        {
            return CCC.SetThreadCulture(Name, Override);
        }

        [JSInvokable("HelperSetThreadUICulture")]
        //[JSInvokableAttribute("HelperSetThreadUICulture")]
        public static bool SetThreadUICulture(string Name = Internal.CultureName, bool Override = Internal.CultureOverride)
        {
            return CCC.SetThreadUICulture(Name, Override);
        }
    }
}