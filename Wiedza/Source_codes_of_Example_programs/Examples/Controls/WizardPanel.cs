using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Controls
{
    public partial class WizardPanel : UserControl
    {
        public WizardPanel()
        {
            InitializeComponent();
        }

        public virtual bool IsFirst
        {
            get { return true; }
        }

        public virtual bool IsLast
        {
            get { return true; }
        }

        public virtual WizardPanel GetNext() { return null; }

        public virtual WizardPanel GetPrevious() { return null; }
    }
}
