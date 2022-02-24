using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example06a
{
    public partial class SetUpPanel : WizardPanel
    {
        public SetUpPanel(int defaultNumber, NeuronType neuronType)
        {
            InitializeComponent();
            uiInputCount.Value = defaultNumber;
            switch (neuronType)
            {
                case NeuronType.Unipolar:
                    uiUnipolar.Checked = true;
                    break;
                case NeuronType.Bipolar:
                    uiBipolar.Checked = true;
                    break;
            }
        }

        public override bool IsLast
        {
            get { return false; }
        }

        public override WizardPanel GetNext()
        {
            NeuronType ntype =
                uiUnipolar.Checked ? NeuronType.Unipolar : NeuronType.Bipolar;
            return new ExperimentPanel((int)uiInputCount.Value, ntype);
        }
    }
}

