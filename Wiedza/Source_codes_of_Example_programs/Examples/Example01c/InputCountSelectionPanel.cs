using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example01c
{
    public partial class InputCountSelectionPanel : WizardPanel
    {
        public InputCountSelectionPanel(int defaultNumber)
        {
            InitializeComponent();
            uiInputCount.Value = defaultNumber;
        }

        public override bool IsLast
        {
            get { return false; }
        }

        public override WizardPanel GetNext()
        {
            return new ExperimentPanel((int)uiInputCount.Value);
        }
    }
}

