﻿using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Struct;

namespace Taiizor.Essentials.Maui.Value
{
    internal class Internal
    {
        public static readonly string StorageExtension = ".json";

        public static readonly string CacheDirectory = FileSystem.Current.CacheDirectory;

        public static readonly string DataDirectory = FileSystem.Current.AppDataDirectory;

        public static readonly PropertyStruct DefaultProperty = new()
        {
            Resizable = true,
            Minimizable = true,
            Maximizable = true,
            AlwaysOnTop = false,
            MoveAndResize = null
        };

        public static Dictionary<AppEnum, bool> AppFullscreen = new()
        {
            { AppEnum.iOS, true },
            { AppEnum.macOS, true },
            { AppEnum.Android, true },
            { AppEnum.Windows, true }
        };

        public static Dictionary<AppEnum, PropertyStruct> AppProperties = new()
        {
            { AppEnum.iOS, DefaultProperty },
            { AppEnum.macOS, DefaultProperty },
            { AppEnum.Android, DefaultProperty },
            { AppEnum.Windows, DefaultProperty }
        };
    }
}