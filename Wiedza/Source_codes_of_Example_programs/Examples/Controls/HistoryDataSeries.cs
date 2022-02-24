using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RTadeusiewicz.NN.Controls
{
    public class HistoryDataSeries : DataSeries
    {
        public HistoryDataSeries(int maxBufferSize)
        {
            if (maxBufferSize < 2)
                throw new ArgumentOutOfRangeException("maxBufferSize");
            _maxBufferSize = maxBufferSize;
            _buffer = new NotifyingList<float>();
            _buffer.Change += new EventHandler(_buffer_Change);
        }

        public HistoryDataSeries() : this(2000) { }

        private NotifyingList<float> _buffer;

        public NotifyingList<float> Buffer
        {
            get { return _buffer; }
        }

        private int _maxBufferSize;

        public int MaxBufferSize
        {
            get { return _maxBufferSize; }
            set
            {
                _maxBufferSize = value;
                CheckBufferLength();
                if (PlotterControl != null)
                    PlotterControl.Invalidate();
            }
        }

        private float _stepLength = 1.0f;

        public float StepLength
        {
            get { return _stepLength; }
            set
            {
                _stepLength = value;
                if (PlotterControl != null)
                    PlotterControl.Invalidate();
            }
        }

        public enum LengthMode { Space, Screen };

        private LengthMode _stepLengthMode = LengthMode.Space;

        public LengthMode StepLengthMode
        {
            get { return _stepLengthMode; }
            set { _stepLengthMode = value; }
        }

        private bool _bufferTrimming;

        private void _buffer_Change(object sender, EventArgs e)
        {
            // Check this to avoid infinite recursion.
            if (_bufferTrimming)
                return;
            CheckBufferLength();
            if (PlotterControl != null)
                PlotterControl.Invalidate();
        }

        private void CheckBufferLength()
        {
            _bufferTrimming = true;
            while (_buffer.Count > MaxBufferSize)
                _buffer.RemoveAt(0);
            _bufferTrimming = false;
        }

        private Point[] _linesToDraw;

        public override void Paint(System.Drawing.Graphics gr)
        {
            if (PlotterControl == null)
                throw new InvalidOperationException("PlotterControl is null");
            if (_buffer.Count < 2)
                return;

            int linesCount = 0;
            switch (_stepLengthMode)
            {
                case LengthMode.Space:
                    linesCount = (int)Math.Ceiling(
                        PlotterControl.VisibleRectangle.Width / _stepLength) + 1;
                    break;
                case LengthMode.Screen:
                    linesCount = (int)Math.Ceiling(
                        PlotterControl.ClientRectangle.Width / _stepLength) + 1;
                    break;
            }
            if (linesCount > _buffer.Count)
                linesCount = _buffer.Count;

            using (Pen pen = new Pen(ForeColor, LineWidth))
            {
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                if (_linesToDraw == null || _linesToDraw.Length != linesCount)
                    _linesToDraw = new Point[linesCount];

                float vRectRight = PlotterControl.VisibleRectangle.Right;
                int cRectWidth = PlotterControl.ClientRectangle.Width;

                for (int i = 0, bufElem = _buffer.Count - 1;
                    i < linesCount && bufElem >= 0;
                    i++, bufElem--)
                {
                    Point chartPoint = Point.Empty;
                    switch (_stepLengthMode)
                    {
                        case LengthMode.Space:
                            chartPoint =
                                PlotterControl.Space2Screen(
                                new PointF(vRectRight - i * _stepLength,
                                _buffer[bufElem]));
                            break;
                        case LengthMode.Screen:
                            chartPoint = new Point(
                                (int)(cRectWidth - i * _stepLength),
                                PlotterControl.SpaceY2ScreenY(_buffer[bufElem]));
                            break;
                    }

                    _linesToDraw[i] =
                        LimitPoint(chartPoint);
                }

                gr.DrawLines(pen, _linesToDraw);
            }
        }

    }
}
