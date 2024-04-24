using AccessModifiers.UiLibrary.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.AcmeUiLibrary
{
    public class AcmeGrid : UiControl
    {
        private int NumberOfRows;
        private int NumberOfColumns;

        void PrintGridProperties()
        {
            // accessible from UiControl
            Console.WriteLine("Width=" + Width);
            // Console.WriteLine(CanFocus);
        }
    }
}
