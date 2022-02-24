using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example01c
{
    public partial class MainForm : RTadeusiewicz.NN.Controls.WizardForm
    {
        public MainForm()
        {
            InitializeComponent();
            CurrentPanel = new InputCountSelectionPanel(5);
        }
    }
}

