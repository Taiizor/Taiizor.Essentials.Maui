using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security.Principal;
using System.Text;
using Taiizor.Essentials.AppCenter.Value;
using AC = Microsoft.AppCenter.AppCenter;

namespace Taiizor.Essentials.Services
{
    public class AppCenterService
    {
        public static void Engine(string Key)
        {
            Keys(Key);
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

        private static void Start()
        {
            AC.Start(Internal.AppCenterKey, typeof(Analytics), typeof(Crashes));

            Internal.AppCenterState = true;
        }

        private static void Keys(string Key)
        {
            if (Key != null && !string.IsNullOrEmpty(Key))
            {
                Internal.AppCenterKey = Key;
            }
        }

        private static void Country()
        {
            AC.SetCountryCode(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            //AC.SetCountryCode(RegionInfo.CurrentRegion.TwoLetterISORegionName);
            //AC.SetCountryCode(CultureInfo.InstalledUICulture.TwoLetterISOLanguageName);
        }

        private static void User()
        {
            try
            {
                string Name = WindowsIdentity.GetCurrent().Name;
                string Unique = "Unknown";

                if (Name.Contains("\\"))
                {
                    Name = Name.Split('\\')[1];
                }
                else
                {
                    Name = Environment.MachineName;
                }

                if (string.IsNullOrEmpty(Name))
                {
                    Name = Environment.UserName;
                }

                string Try = WindowsIdentity.GetCurrent().User.Value;

                if (!string.IsNullOrEmpty(Try) && Try.Contains("-") && Try.Split('-').Length >= 6)
                {
                    Unique = WindowsIdentity.GetCurrent().User.Value.Split('-')[5];
                }

                AC.SetUserId($"{Name}-{Unique}");
            }
            catch
            {
                AC.SetUserId("Unknown");
            }
        }

        private static void Level()
        {
            AC.LogLevel = LogLevel.Verbose;
        }

        private static void Enabled()
        {
            Crashes.SetEnabledAsync(true);
        }
    }
}