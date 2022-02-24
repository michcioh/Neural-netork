using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example03
{
    public partial class MainForm : RTadeusiewicz.NN.Controls.WizardForm
    {
        public MainForm()
        {
            InitializeComponent();
            ProgramLogic pl = new ProgramLogic();
            pl.ProgressHistory.AntiAlias = true;
            pl.ProgressHistory.StepLength = 2.0f;
            pl.ProgressHistory.StepLengthMode = HistoryDataSeries.LengthMode.Screen;
            CurrentPanel = new SetUpPanel(pl);
        }

    }
}

