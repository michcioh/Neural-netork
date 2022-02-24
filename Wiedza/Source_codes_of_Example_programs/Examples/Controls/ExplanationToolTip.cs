using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Controls
{
    public partial class ExplanationToolTip : UserControl
    {
        public ExplanationToolTip()
        {
            InitializeComponent();
        }

        private string _toolTipText;

        [Category("Behavior"),
        Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design",
            typeof(System.Drawing.Design.UITypeEditor))]
        public string ToolTipText
        {
            get { return _toolTipText; }
            set
            {
                uiToolTip.SetToolTip(uiLabel, _toolTipText = value);
            }
        }

        protected override Size DefaultSize
        {
            get { return new Size(23, 23); }
        }

        /// <summary>
        /// Ustawia dymek podpowiedzi dla etykiety.
        /// </summary>
        /// <remarks>
        /// U�ycie tego dziwnego triku jest konieczne ze wzgl�du na bardzo brzydk�
        /// pluskw� w obs�udze dymk�w podpowiedzi w platformie .Net; w pewnych
        /// warunkach, mog� si� one po jakim� czasie po prostu przesta� pokazywa�.
        /// </remarks>
        private void uiLabel_MouseEnter(object sender, EventArgs e)
        {
            uiToolTip.RemoveAll();
            uiToolTip.SetToolTip(uiLabel, _toolTipText);
        }
    }
}
