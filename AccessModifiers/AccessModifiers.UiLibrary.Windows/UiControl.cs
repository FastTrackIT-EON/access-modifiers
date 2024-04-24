using System;

namespace AccessModifiers.UiLibrary.Windows
{
    public class UiControl
    {
        private int Height;
        protected int Width;

        internal bool CanFocus;
        private bool HasChildren;
        public string BackgroundColor;
        private string ForegroundColor;

        public static string WindowsVersion = "Windows 10";

        void PrintControlProperties()
        {
            Console.WriteLine("Height" + Height);
            Console.WriteLine("Width" + Width);
            Console.WriteLine("CanFocus" + CanFocus);
            Console.WriteLine("HasChildren" + HasChildren);
            Console.WriteLine("BackgroundColor" + BackgroundColor);
            Console.WriteLine("ForegroundColor" + ForegroundColor);

            Console.WriteLine(UiControl.WindowsVersion);
        }

    }
}
