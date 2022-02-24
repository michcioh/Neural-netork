using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example11
{
    public partial class SetUp : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;

        internal SetUp(ProgramLogic programLogic)
        {
            _programLogic = programLogic;
            InitializeComponent();
        }

        public override bool IsLast
        {
            get { return false; }
        }

        public override WizardPanel GetNext()
        {
            _programLogic.LoadTeachingSet(
                   Convert.ToInt16(uiNetSizeX.Value),
                   Convert.ToInt16(uiNetSizeY.Value),
                   Convert.ToDouble(uiWeights.Value)
                   );

            return new Simulation(_programLogic);
        }
    }
}

