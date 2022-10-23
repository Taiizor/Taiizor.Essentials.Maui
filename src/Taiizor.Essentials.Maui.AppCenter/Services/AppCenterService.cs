using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Newtonsoft.Json;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Text;
using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Struct;
using Taiizor.Essentials.Maui.AppCenter.Value;
using AC = Microsoft.AppCenter.AppCenter;
using HK = Taiizor.Essentials.Maui.AppCenter.Helper.Key;
using HW = Taiizor.Essentials.Maui.AppCenter.Helper.Watch;

#if WINDOWS

using Unhandled = Microsoft.UI.Xaml.UnhandledExceptionEventArgs;

#endif

namespace Taiizor.Essentials.Maui.AppCenter.Services
{
    public class AppCenterService
    {
        public static void Engine(Dictionary<AppEnum, string> Keys)
        {
            Engine(Keys, Internal.AppCenterWatch);
        }

        public static void Engine(Dictionary<AppEnum, string> Keys, WatchStruct Watch)
        {
            Internal.AppCenterWatch = Watch;

            Key(Keys);

            Enabled(); //
            Level(); //
            User();
            Country();

            Start();
        }

        public static void TestCrash()
        {
            if (Internal.AppCenterState)
            {
                Crashes.GenerateTestCrash();

                WatchError("TestCrash");
            }
        }

        public static void Exception(FirstChanceExceptionEventArgs e)
        {
            if (Internal.AppCenterState)
            {
                TrackError(e.Exception, "FirstChanceMessage", e.Exception.Message);
            }
        }

        public static void Exception(UnhandledExceptionEventArgs e)
        {
            if (Internal.AppCenterState)
            {
                TrackError((Exception)e.ExceptionObject, "UnhandledMessage", ((Exception)e.ExceptionObject).Message);
            }
        }

#if WINDOWS

        public static void Exception(Unhandled e)
        {
            if (Internal.AppCenterState)
            {
                TrackError(e.Exception, "UnhandledMessage", e.Exception.Message);
            }
        }

#endif

        public static void Exception(UnobservedTaskExceptionEventArgs e)
        {
            if (Internal.AppCenterState)
            {
                TrackError(e.Exception, "UnobservedMessage", e.Exception.Message);
            }
        }

        public static void Exception(Exception e)
        {
            if (Internal.AppCenterState)
            {
                TrackError(e);
            }
        }

        public static void TrackEvent(string Name)
        {
            if (Internal.AppCenterState)
            {
                Analytics.TrackEvent(Name);

                WatchEvent(Name);
            }
        }

        public static void TrackEvent(string Name, string Key, string Value)
        {
            if (Internal.AppCenterState)
            {
                Analytics.TrackEvent(Name, new Dictionary<string, string>() { { Key, Value } });

                WatchEvent(Name, Key, Value);
            }
        }

        public static void TrackEvent(string Name, IDictionary<string, string> Properties = null)
        {
            if (Internal.AppCenterState)
            {
                Analytics.TrackEvent(Name, Properties);

                WatchEvent(Name, Properties);
            }
        }

        public static void TrackError(Exception Exception)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception);

                WatchError(Exception);
            }
        }

        public static void TrackError(Exception Exception, string Key, string Value)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception, new Dictionary<string, string>() { { Key, Value } });

                WatchError(Exception, Key, Value);
            }
        }

        public static void TrackError(Exception Exception, IDictionary<string, string> Properties = null)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception, Properties);

                WatchError(Exception, Properties);
            }
        }

        public static void TrackError(Exception Exception, IDictionary<string, string> Properties = null, string Text = "Hello World!", string TextFile = "Hello.txt", string Image = "Fake Image", string ImageFile = "fake_image.jpeg", string Extension = "image/jpeg")
        {
            if (Internal.AppCenterState)
            {
                TrackError(Exception, Properties, new ErrorAttachmentLog[]
                {
                    ErrorAttachmentLog.AttachmentWithText(Text, TextFile),
                    ErrorAttachmentLog.AttachmentWithBinary(Encoding.UTF8.GetBytes(Image), ImageFile, Extension)
                });
            }
        }

        public static void TrackError(Exception Exception, IDictionary<string, string> Properties = null, string Text = "Hello World!", string TextFile = "Hello.txt", byte[] Image = null, string ImageFile = "fake_image.jpeg", string Extension = "image/jpeg")
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception, Properties, new ErrorAttachmentLog[]
                {
                    ErrorAttachmentLog.AttachmentWithText(Text, TextFile),
                    ErrorAttachmentLog.AttachmentWithBinary(Image, ImageFile, Extension)
                });

                WatchError(Exception, Properties, new ErrorAttachmentLog[]
                {
                    ErrorAttachmentLog.AttachmentWithText(Text, TextFile),
                    ErrorAttachmentLog.AttachmentWithBinary(Image, ImageFile, Extension)
                });
            }
        }

        public static void TrackError(Exception Exception, IDictionary<string, string> Properties = null, ErrorAttachmentLog[] Attachments = null)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception, Properties, Attachments);

                WatchError(Exception, Properties, Attachments);
            }
        }

        internal static void WatchEvent(string Name)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Event == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.EventName), new Dictionary<string, string>() { { "Name", Name } });
            }
        }

        internal static void WatchEvent(string Name, string Key, string Value)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Event == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.EventName), new Dictionary<string, string>() { { Name, $"{Key}: {Value}" } });
            }
        }

        internal static void WatchEvent(string Name, IDictionary<string, string> Properties)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Event == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.EventName), new Dictionary<string, string>() { { Name, JsonConvert.SerializeObject(Properties, Formatting.None) } }); //Formatting.Indented
            }
        }

        internal static void WatchError(string Name)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Error == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.ErrorName), new Dictionary<string, string>() { { "Error", Name } });
            }
        }

        internal static void WatchError(Exception Exception)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Error == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.ErrorName), new Dictionary<string, string>() { { "Error", JsonConvert.SerializeObject(Exception, Formatting.None) } }); //Formatting.Indented
            }
        }

        internal static void WatchError(Exception Exception, string Key, string Value)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Error == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.ErrorName), new Dictionary<string, string>() { { Key, Value }, { "Error", JsonConvert.SerializeObject(Exception, Formatting.None) } }); //Formatting.Indented
            }
        }

        internal static void WatchError(Exception Exception, IDictionary<string, string> Properties)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Error == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.ErrorName), new Dictionary<string, string>() { { "Properties", JsonConvert.SerializeObject(Properties, Formatting.None) }, { "Error", JsonConvert.SerializeObject(Exception, Formatting.None) } }); //Formatting.Indented
            }
        }

        internal static void WatchError(Exception Exception, IDictionary<string, string> Properties, ErrorAttachmentLog[] Attachments)
        {
            if (Internal.AppCenterState && Internal.AppCenterWatch.Error == WatchEnum.Open)
            {
                Analytics.TrackEvent(HW.GetText(Internal.AppCenterWatch.ErrorName), new Dictionary<string, string>() { { "Properties", JsonConvert.SerializeObject(Properties, Formatting.None) }, { "Attachments", JsonConvert.SerializeObject(Attachments, Formatting.None) }, { "Error", JsonConvert.SerializeObject(Exception, Formatting.None) } }); //Formatting.Indented
            }
        }

        private static void Key(Dictionary<AppEnum, string> Keys)
        {
            if (Keys != null && Keys.Keys.Count > 0)
            {
                foreach (AppEnum App in Keys.Keys)
                {
                    if (!string.IsNullOrEmpty(Keys[App]))
                    {
                        Internal.AppCenterKey[App] = Keys[App];
                    }
                }
            }
        }

        private static void Start()
        {
            AC.Start(HK.GetText(Internal.AppCenterKey), typeof(Analytics), typeof(Crashes)); //Internal.AppCenterKey[AppEnum.Android]

            Internal.AppCenterState = true;
        }

        private static void Country()
        {
            AC.SetCountryCode(CountryCode);
        }

        private static void User()
        {
            AC.SetUserId(UserId);
        }

        private static void Level()
        {
            AC.LogLevel = LogLevel.Verbose;
        }

        private static void Enabled()
        {
            Crashes.SetEnabledAsync(true);
            Analytics.SetEnabledAsync(true);
        }
        
        internal static string CountryCode
        {
            get
            {
                //return RegionInfo.CurrentRegion.Name;
                return RegionInfo.CurrentRegion.TwoLetterISORegionName;
                //return CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
                //return CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
            }
        }

        internal static string UserId
        {
            get
            {
                string Name = string.IsNullOrEmpty(DeviceInfo.Current.Name) ? Internal.Unknown : DeviceInfo.Current.Name;
                string Model = string.IsNullOrEmpty(DeviceInfo.Current.Model) ? Internal.Unknown : DeviceInfo.Current.Model;

                return $"{Name}-{Model}";
            }
        }
    }
}