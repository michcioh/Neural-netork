using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NeuralNet;

namespace ModifyBitmap
{
    public partial class ColorRecognize : Form
    {
        Color colorToRecognize;
        ColorRecognizeTools colorRecognizeTools = new ColorRecognizeTools();

        public ColorRecognize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cdChooseColor.ShowDialog(this) == DialogResult.OK)
            {
                colorToRecognize = cdChooseColor.Color;
                pSource.BackColor = colorToRecognize;
                bool collect = false;
                Color answer = colorRecognizeTools.RecognizeColorByNN(colorToRecognize, ref collect);
                pDestination.BackColor = answer;
            }
        }

        private void ColorRecognize_Load(object sender, EventArgs e)
        {
            if (!colorRecognizeTools.IsNetworkLoaded())
            {
                MessageBox.Show(this, "Error during network loading... Window will not work.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } else
            {
                //AllocConsole();
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}