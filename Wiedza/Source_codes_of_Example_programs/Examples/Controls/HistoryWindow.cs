using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Controls
{
    public partial class HistoryWindow : Form
    {
        public HistoryWindow(HistoryDataSeries data)
        {
            InitializeComponent();
            uiHistoryPlotter.DataSeries.Add(data);
            uiHistoryPlotter.VisibleRectangle =
                new RectangleF(-0.1f, -0.1f, 1.2f, 1.2f);
        }
    }
}