using AccessModifiers.UiLibrary.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UiControl control = new UiControl();
            Console.WriteLine(control.BackgroundColor);
            // control.Height
            // control.Width

            UiButton button = new UiButton();
            // button.Image

            Console.WriteLine(UiControl.WindowsVersion);
        }
    }
}
