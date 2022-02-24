using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            SignalFilter signalFilter = new SignalFilter();
            Application.Run();            
        }
    }
}