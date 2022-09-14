namespace Taiizor.Essentials.Maui.Extension.Storage
{
    public class Preference
    {
        public static void Set(string Key, int Value)
        {
            Preferences.Set(Key, Value);
        }
        
        public static void Set(string Key, long Value)
        {
            Preferences.Set(Key, Value);
        }
        
        public static void Set(string Key, float Value)
        {
            Preferences.Set(Key, Value);
        }

        public static void Set(string Key, double Value)
        {
            Preferences.Set(Key, Value);
        }

        public static void Set(string Key, bool Value)
        {
            Preferences.Set(Key, Value);
        }

        public static void Set(string Key, string Value)
        {
            Preferences.Set(Key, Value);
        }

        public static void Set(string Key, DateTime Value)
        {
            Preferences.Set(Key, Value);
        }

        public static int Get(string Key, int Value = 0)
        {
            return Preferences.Get(Key, Value);
        }

        public static long Get(string Key, long Value = 0)
        {
            return Preferences.Get(Key, Value);
        }

        public static float Get(string Key, float Value = 0f)
        {
            return Preferences.Get(Key, Value);
        }
        
        public static double Get(string Key, double Value = 0d)
        {
            return Preferences.Get(Key, Value);
        }

        public static bool Get(string Key, bool Value = false)
        {
            return Preferences.Get(Key, Value);
        }

        public static string Get(string Key, string Value = "")
        {
            return Preferences.Get(Key, Value);
        }

        public static DateTime Get(string Key, DateTime Value = new())
        {
            return Preferences.Get(Key, Value);
        }

        public static bool Check(string Key)
        {
            return Preferences.ContainsKey(Key);
        }

        public static void Clear()
        {
            Preferences.Clear();
        }

        public static void Delete(string Key, bool Execute = false)
        {
            if (Check(Key) || Execute)
            {
                Preferences.Remove(Key);
            }
        }
    }
}