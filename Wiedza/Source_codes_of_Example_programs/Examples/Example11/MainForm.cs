using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example11
{
    public partial class MainForm : RTadeusiewicz.NN.Controls.WizardForm
    {
        public MainForm()
        {
            InitializeComponent();
            ProgramLogic pl = new ProgramLogic();
            CurrentPanel = new SetUp(pl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

