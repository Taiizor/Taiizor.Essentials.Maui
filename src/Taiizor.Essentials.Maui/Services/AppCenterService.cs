using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System.Globalization;
using System.Text;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;
using Device = Taiizor.Essentials.Maui.Extension.Device;

#if ANDROID || IOS || MACCATALYST || WINDOWS

using Service = Taiizor.Essentials.Maui.Platforms.Services.AppCenterService;

#endif

namespace Taiizor.Essentials.Maui.Services
{
    public class AppCenterService
    {
        public static void Engine(Dictionary<AppEnum, string> Keys)
        {
            Key(Keys);
            Enabled(); //
            Level(); //
            User();
            Country();

#if ANDROID || IOS || MACCATALYST || WINDOWS

            Service.Start();

#endif
        }

        public static void TestCrash()
        {
            if (Internal.AppCenterState)
            {
                Crashes.GenerateTestCrash();
            }
        }

        public static void Exception(UnhandledExceptionEventArgs e)
        {
            if (Internal.AppCenterState)
            {
                TrackError((Exception)e.ExceptionObject, "Message", ((Exception)e.ExceptionObject).Message);
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
            }
        }

        public static void TrackEvent(string Name, string Key, string Value)
        {
            if (Internal.AppCenterState)
            {
                Analytics.TrackEvent(Name, new Dictionary<string, string>() { { Key, Value } });
            }
        }

        public static void TrackEvent(string Name, IDictionary<string, string> Properties = null)
        {
            if (Internal.AppCenterState)
            {
                Analytics.TrackEvent(Name, Properties);
            }
        }

        public static void TrackError(Exception Exception)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception);
            }
        }

        public static void TrackError(Exception Exception, string Key, string Value)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception, new Dictionary<string, string>() { { Key, Value } });
            }
        }

        public static void TrackError(Exception Exception, IDictionary<string, string> Properties = null)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception, Properties);
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
            }
        }

        public static void TrackError(Exception Exception, IDictionary<string, string> Properties = null, ErrorAttachmentLog[] Attachments = null)
        {
            if (Internal.AppCenterState)
            {
                Crashes.TrackError(Exception, Properties, Attachments);
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

        private static void Country()
        {
            AppCenter.SetCountryCode(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            //AppCenter.SetCountryCode(RegionInfo.CurrentRegion.TwoLetterISORegionName);
            //AppCenter.SetCountryCode(CultureInfo.InstalledUICulture.TwoLetterISOLanguageName);
        }

        private static void User()
        {
            AppCenter.SetUserId($"{Device.Name}-{Device.Model}");
        }

        private static void Level()
        {
            AppCenter.LogLevel = LogLevel.Verbose;
        }

        private static void Enabled()
        {
            Crashes.SetEnabledAsync(true);
        }
    }
}