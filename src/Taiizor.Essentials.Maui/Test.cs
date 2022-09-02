namespace Taiizor.Essentials.Maui
{
    // All the code in this file is included in all platforms.
    public class Test
    {

#if ANDROID || IOS || MACCATALYST || WINDOWS
        public static string Tester => PlatformTest.Test;
#endif
    }
}