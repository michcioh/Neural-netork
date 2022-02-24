using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example10a
{
    public partial class MainForm1 : RTadeusiewicz.NN.Controls.WizardForm
    {
        public MainForm1()
        {
            InitializeComponent();
            ProgramLogic pl = new ProgramLogic();
            pl.Randomize(true);        
            CurrentPanel = new SetUp(pl);
          
        }
    }
}

