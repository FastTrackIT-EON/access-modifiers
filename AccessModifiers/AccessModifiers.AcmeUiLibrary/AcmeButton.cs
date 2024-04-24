using AccessModifiers.UiLibrary.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.AcmeUiLibrary
{
    public class AcmeButton : UiButton
    {
        void PrintAcmeButtonProperties()
        {
            // Console.Write(Image);
            Console.WriteLine(BackgroundColor);
        }
    }
}
