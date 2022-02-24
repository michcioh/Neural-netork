using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Controls
{
    public partial class WizardForm : Form
    {
        public WizardForm()
        {
            InitializeComponent();
        }

        private WizardPanel _currentPanel;

        public WizardPanel CurrentPanel
        {
            get { return _currentPanel; }
            set {
                if (_currentPanel == value)
                    return;
                SuspendLayout();
                if (_currentPanel != null)
                    uiContainerPanel.Controls.Remove(_currentPanel);
                _currentPanel = value;
                if (_currentPanel != null)
                {
                    uiContainerPanel.Controls.Add(_currentPanel);
                    _currentPanel.Dock = DockStyle.Fill;
                    uiNext.Enabled = !_currentPanel.IsLast;
                    uiBack.Enabled = !_currentPanel.IsFirst;
                }
                ResumeLayout();
            }
        }

        private void uiNext_Click(object sender, EventArgs e)
        {
            if (CurrentPanel != null)
            {
                CurrentPanel = CurrentPanel.GetNext();
            }
        }

        private void uiBack_Click(object sender, EventArgs e)
        {
            if (CurrentPanel != null)
            {
                CurrentPanel = CurrentPanel.GetPrevious();
            }
        }

    }
}