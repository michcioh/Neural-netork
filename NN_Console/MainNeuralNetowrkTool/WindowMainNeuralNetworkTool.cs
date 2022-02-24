using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainNeuralNetowrkTool
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifyBitmap.WindowModifyBitmap w = new ModifyBitmap.WindowModifyBitmap();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data_for_neural_networks.WindowDataForNeuralNetworks w = new Data_for_neural_networks.WindowDataForNeuralNetworks();
            w.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start("NN_Console.exe");
        }
    }
}
