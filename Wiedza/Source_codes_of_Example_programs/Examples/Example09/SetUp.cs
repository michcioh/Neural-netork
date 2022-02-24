using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example09
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
            //_programLogic.
              //  .Neurons = nrLayers.Value;
           // _programLogic.Neurons = new int[nrLayers.Value+2];
             _programLogic.Layers = Convert.ToInt16(nrLayers.Value);

            //_programLogic.Neurons[1] = nrLay1.Value;
           // _programLogic.Neurons[2] = nrLay2.Value;

            //for (int i=0 ; i < nrLayers ; i++)
                _programLogic.n[0] = 2;
                _programLogic.n[1] = Convert.ToInt16(nrLay1.Value);
                _programLogic.n[2] = Convert.ToInt16(nrLay2.Value);

                _programLogic.n[Convert.ToInt16(nrLayers.Value)] = 1;


                _programLogic.c[0,0] = Convert.ToDouble(nX1.Value);
                _programLogic.c[0,1] = -Convert.ToDouble(nY1.Value);
                _programLogic.r[0] = Convert.ToDouble(nR1.Value);

                _programLogic.c[1,0] = Convert.ToDouble(nX2.Value);
                _programLogic.c[1,1] = -Convert.ToDouble(nY2.Value);
                _programLogic.r[1] = Convert.ToDouble(nR2.Value);

                _programLogic.c[2,0] = Convert.ToDouble(nX3.Value);
                _programLogic.c[2,1] = -Convert.ToDouble(nY3.Value);
                _programLogic.r[2] = Convert.ToDouble(nR3.Value);

                _programLogic.InitializeTeaching();

            return new Simulation(_programLogic);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (nrLayers.Value == 1)
            {
                nrLay1.Enabled = false;
                nrLay2.Enabled = false;

                nrLay1.Visible = false;
                nrLay2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;

            }
            if (nrLayers.Value == 2)
            {
                nrLay1.Enabled = true;
                nrLay2.Enabled = false;

                nrLay1.Visible = true;
                nrLay2.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
            }
            if (nrLayers.Value == 3)
            {
                nrLay1.Enabled = true;
                nrLay2.Enabled = true;
                nrLay1.Value = 10;
                nrLay2.Value = 10;

                nrLay1.Visible = true;
                nrLay2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }

        }
    }
}

