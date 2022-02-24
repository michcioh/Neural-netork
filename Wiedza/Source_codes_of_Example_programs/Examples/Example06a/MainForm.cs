using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example06a
{
    public partial class MainForm : RTadeusiewicz.NN.Controls.WizardForm
    {
        public MainForm()
        {
            InitializeComponent();
            CurrentPanel = new SetUpPanel(4, NeuronType.Unipolar);
        }
    }
}

