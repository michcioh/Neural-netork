using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RTadeusiewicz.NN.Controls
{
    public partial class ChartPlotter : ChartSurface
    {
        public ChartPlotter()
        {
            InitializeComponent();
            _dataSeries = new DataSeriesCollection(this);
        }

        private DataSeriesCollection _dataSeries;

        public DataSeriesCollection DataSeries
        {
            get { return _dataSeries; }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            foreach (DataSeries ds in _dataSeries)
            {
                pe.Graphics.SmoothingMode =
                    ds.AntiAlias ? SmoothingMode.AntiAlias : SmoothingMode.Default;
                ds.Paint(pe.Graphics);
            }
        }
    }
}
