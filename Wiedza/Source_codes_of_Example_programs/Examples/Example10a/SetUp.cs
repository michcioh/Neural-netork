using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example10a
{
    public partial class SetUp : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;

       

        internal SetUp(ProgramLogic programLogic)
        {
            _programLogic = programLogic;
            InitializeComponent();
            cbRandomize.Checked = _programLogic.Randomize();
        }

        public override bool IsLast
        {
            get { return false; }
        }

        public override WizardPanel GetNext()
        {
            _programLogic.Randomize(cbRandomize.Checked);
            _programLogic._randomGenerator = null;
            _programLogic.LoadTeachingSet(
                   Convert.ToInt16(uiNeurons.Value),
                   Convert.ToDouble(uiEthaFactor.Value)
                   );           
           _programLogic.PerformTeaching();
         
                    
            return new Simulation(_programLogic);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

