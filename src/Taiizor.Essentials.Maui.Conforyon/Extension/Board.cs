using Microsoft.JSInterop;
using CBA = Conforyon.Board.Audio;
using CBT = Conforyon.Board.Text;

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
            [JSInvokable("BoardTextCopyInteger")]
            //[JSInvokableAttribute("BoardTextCopyInteger")]
            public static void CopyInteger(int Number)
            {
                CBT.Copy(Number);
            }

            [JSInvokable("BoardTextCopyLong")]
            //[JSInvokableAttribute("BoardTextCopyLong")]
            public static void CopyLong(long Number)
            {
                CBT.Copy(Number);
            }

            [JSInvokable("BoardTextCopyDouble")]
            //[JSInvokableAttribute("BoardTextCopyDouble")]
            public static void CopyDouble(double Number)
            {
                CBT.Copy(Number);
            }

            [JSInvokable("BoardTextCopyFloat")]
            //[JSInvokableAttribute("BoardTextCopyFloat")]
            public static void CopyFloat(float Number)
            {
                CBT.Copy(Number);
            }

            [JSInvokable("BoardTextCopyObject")]
            //[JSInvokableAttribute("BoardTextCopyObject")]
            public static void CopyObject(object Value)
            {
                CBT.Copy(Value);
            }

            [JSInvokable("BoardTextCopyText")]
            //[JSInvokableAttribute("BoardTextCopyText")]
            public static void CopyText(string Text)
            {
                CBT.Copy(Text);
            }
            
            [JSInvokable("BoardTextPasteText")]
            //[JSInvokableAttribute("BoardTextPasteText")]
            public static string PasteText(bool Clear = false, string Empty = "Empty!")
            {
                return CBT.Paste(Clear);
            }
        }
    }
}