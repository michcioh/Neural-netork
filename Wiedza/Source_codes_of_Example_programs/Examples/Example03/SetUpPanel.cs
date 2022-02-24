using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example03
{
    public partial class SetUpPanel : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;

        internal SetUpPanel(ProgramLogic programLogic)
        {
            _programLogic = programLogic;
            InitializeComponent();
            if (_programLogic.TeachingSetFileName != null)
                uiOpenFile.FileName = uiTeachingSet.Text =
                    _programLogic.TeachingSetFileName;
            else
                ResetToDefault();
        }

        private void ResetToDefault()
        {
            Directory.SetCurrentDirectory(
                uiOpenFile.InitialDirectory = Application.StartupPath);
            uiOpenFile.FileName = uiTeachingSet.Text = "Default teaching set 03.txt";
        }

        private void uiTeachingSetReset_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }

        private void uiTeachingSetBrowse_Click(object sender, EventArgs e)
        {
            if (uiOpenFile.ShowDialog(this) == DialogResult.OK)
                uiTeachingSet.Text = uiOpenFile.FileName;
        }

        public override bool IsLast
        {
            get { return false; }
        }

        public override WizardPanel GetNext()
        {
            try
            {
                _programLogic.LoadTeachingSet(uiTeachingSet.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(this,
                    "You are supposed to enter a valid file name. If you don't " +
                    "know what to do, click \"Reset to default\".",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "The file you specified could not be opened. If you don't " +
                    "know what to do, click \"Reset to default\".\n\n" +
                    "Details: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return this;
            }
            return new TeachingPanel(_programLogic);
        }

    }
}

