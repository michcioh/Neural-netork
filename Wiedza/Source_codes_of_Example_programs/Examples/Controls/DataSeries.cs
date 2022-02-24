using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RTadeusiewicz.NN.Controls
{
    public abstract class DataSeries
    {
        private ChartPlotter _plotterControl;

        public virtual ChartPlotter PlotterControl
        {
            get { return _plotterControl; }
            internal set { _plotterControl = value; }
        }

        private Color _foreColor = SystemColors.WindowText;

        public Color ForeColor
        {
            get { return _foreColor; }
            set
            {
                _foreColor = value;
                if (_plotterControl != null)
                    _plotterControl.Invalidate();
            }
        }

        private float _lineWidth = 1;

        public float LineWidth
        {
            get { return _lineWidth; }
            set 
            { 
                _lineWidth = value;
                if (_plotterControl != null)
                    _plotterControl.Invalidate();
            }
        }

        private bool _antiAlias;

        public bool AntiAlias
        {
            get { return _antiAlias; }
            set
            {
                _antiAlias = value; if (_plotterControl != null)
                    _plotterControl.Invalidate();
            }
        }

        protected static Point LimitPoint(Point pt)
        {
            const int max = 0x10000000;
            const int min = -0x10000000;
            
            Point result = pt;
            if (result.X > max)
                result.X = max;
            if (result.X < min)
                result.X = min;
            if (result.Y > max)
                result.Y = max;
            if (result.Y < min)
                result.Y = min;
            return result;
        }

        public abstract void Paint(Graphics gr);
    }
}
