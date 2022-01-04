using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace DateTimePickerShowRoom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.CurrentCulture = CultureInfo.CreateSpecificCulture("en-us");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}