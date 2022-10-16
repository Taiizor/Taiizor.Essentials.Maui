using Microsoft.JSInterop;
using CBA = Conforyon.Board.Audio;

namespace Taiizor.Essentials.Maui.Conforyon.Extension
{
    public class Board
    {
        public class Audio
        {
            [JSInvokable("BoardAudioCopyPath")]
            //[JSInvokableAttribute("BoardAudioCopyPath")]
            public static void CopyPath(string Path)
            {
                CBA.Copy(Path);
            }

            [JSInvokable("BoardAudioCopyByte")]
            //[JSInvokableAttribute("BoardAudioCopyByte")]
            public static void CopyByte(byte[] Bytes)
            {
                CBA.Copy(Bytes);
            }

            [JSInvokable("BoardAudioPasteStream")]
            //[JSInvokableAttribute("BoardAudioPasteStream")]
            public static Stream PasteStream(bool Clear = false)
            {
                return CBA.Paste(Clear);
            }
        }

        public class Text
        {
            [JSInvokable("TrackEventBasic")]
            //[JSInvokableAttribute("TrackEventBasic")]
            public static void TrackBasic(string Name)
            {
                Console.WriteLine(Name);
            }
        }
    }
}