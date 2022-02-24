using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RTadeusiewicz.NN.Controls
{
    public class ListDataSeries : DataSeries
    {
        public ListDataSeries(int capacity)
        {
            _data = new NotifyingList<PointF>(capacity);
            _data.Change += new EventHandler(_data_Change);
        }

        public ListDataSeries() : this(0) { }

        private NotifyingList<PointF> _data;

        public NotifyingList<PointF> Data
        {
            get { return _data; }
        }

        private bool _continuousLine = true;

        public bool ContinuousLine
        {
            get { return _continuousLine; }
            set
            {
                _continuousLine = value;
                if (PlotterControl != null)
                    PlotterControl.Invalidate();
            }
        }


        private Point[] _linesToDraw;

        public override void Paint(Graphics gr)
        {
            if (PlotterControl == null)
                throw new InvalidOperationException("PlotterControl is null");
            if (_data.Count < 2)
                return;

            using (Pen pen = new Pen(ForeColor, LineWidth))
            {
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                if (_continuousLine)
                {
                    if (_linesToDraw == null || _linesToDraw.Length != _data.Count)
                        _linesToDraw = new Point[_data.Count];

                    for (int i = 0; i < _data.Count; i++)
                        _linesToDraw[i] =
                            LimitPoint(PlotterControl.Space2Screen(_data[i]));

                    gr.DrawLines(pen, _linesToDraw);
                }
                else
                {
                    for (int i = 1; i < _data.Count; i += 2)
                    {
                        Point p1 =
                            LimitPoint(PlotterControl.Space2Screen(_data[i - 1]));
                        Point p2 =
                            LimitPoint(PlotterControl.Space2Screen(_data[i]));
                        gr.DrawLine(pen, p1, p2);
                    }
                }
            }
        }

        private void _data_Change(object sender, EventArgs e)
        {
            if (PlotterControl != null)
                PlotterControl.Invalidate();
        }

    }
}
