using System.Text;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Screen
    {
        public static double Width = DeviceDisplay.Current.MainDisplayInfo.Width;

        public static double Height = DeviceDisplay.Current.MainDisplayInfo.Height;

        public static double Density = DeviceDisplay.Current.MainDisplayInfo.Density;

        public static DisplayOrientation Orientation = DeviceDisplay.Current.MainDisplayInfo.Orientation;

        public static string OrientationString = Orientation.ToString();

        public static DisplayRotation Rotation = DeviceDisplay.Current.MainDisplayInfo.Rotation;

        public static string RotationString = DeviceDisplay.Current.MainDisplayInfo.Rotation.ToString();

        public static float RefreshRate = DeviceDisplay.Current.MainDisplayInfo.RefreshRate;

        public static string Info()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"Density: {Density}");
            stringBuilder.AppendLine($"Rotation: {Rotation}");
            stringBuilder.AppendLine($"Orientation: {Orientation}");
            stringBuilder.AppendLine($"Refresh Rate: {RefreshRate}");
            stringBuilder.AppendLine($"Pixel Width: {Width} / Pixel Height: {Height}");

            return stringBuilder.ToString();
        }
    }
}