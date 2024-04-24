using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.UiLibrary.Windows
{
    public class UiButton : UiControl
    {
        private bool AutoEllipsis;
        string Image;
        private string Text;

        void PrintButtonProperties()
        {
            // not accessible
            // Console.WriteLine("Height" + Height);
           
            // accessible from UiControl
            Console.WriteLine("Width" + Width);
            Console.WriteLine("CanFocus" + CanFocus);
            Console.WriteLine("BackgroundColor" + BackgroundColor);

            Console.WriteLine("AutoEllipsis" + AutoEllipsis);
            Console.WriteLine("Image" + Image);
            Console.WriteLine("Text" + Text);

            UiControl.WindowsVersion
        }
    }
}
