﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModifyBitmap
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowModifyBitmap());
        }
    }
}
