/*
 * UWAGA: Jedynym zadaniem tego pliku jest uruchomienie aplikacji. Czytelnik
 * zainteresowany sieciami neuronowymi nie znajdzie tu niczego istotnego.
 * 
 * Aby obejrzeæ istotne kawa³ki kodu, obejrzyj plik "MainForm.cs".
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example01a
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
            Application.Run(new MainForm());
        }
    }
}