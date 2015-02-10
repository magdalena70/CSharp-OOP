using System;
using System.Runtime.InteropServices;

namespace _11_Attributes_Example
{
    class UsingAttributes
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]

        public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);

        static void Main(string[] args)
        {
            ShowMessageBox(0, "some text", "some caption", 0);
        }
    }
}
