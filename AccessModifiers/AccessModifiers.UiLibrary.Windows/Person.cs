using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.UiLibrary.Windows
{
    public class Person
    {
        void PrintPerson()
        {
            UiControl control = new UiControl();
            control.CanFocus = true;
            control.BackgroundColor = true;
        }
    }
}
