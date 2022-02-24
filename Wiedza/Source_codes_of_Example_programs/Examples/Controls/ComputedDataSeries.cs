using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RTadeusiewicz.NN.Controls
{
    public class ComputedDataSeries : DataSeries
    {
        public delegate double DrawableFunction(double arg);

        public abstract class ParametrizedFunction
        {
            private ComputedDataSeries _owningDataSeries;

            public ComputedDataSeries OwningDataSeries
            {
                get { return _owningDataSeries; }
                internal set
                {
                    _owningDataSeries = value;
                    RefreshView();
                }
            }

            protected void RefreshView()
            {
                if (_owningDataSeries != null &&
                    _owningDataSeries.PlotterControl != null)
                    _owningDataSeries.PlotterControl.Invalidate();
            }

            public abstract double Compute(double arg);
        }

        private DrawableFunction _function;

        public DrawableFunction Function
        {
            get { return _function; }
            set
            {
                _functionObject = null;
                _function = value;
                if (PlotterControl != null)
                    PlotterControl.Invalidate();
            }
        }

        private ParametrizedFunction _functionObject;

        public ParametrizedFunction FunctionObject
        {
            get { return _functionObject; }
            set
            {
                if (_functionObject != null)
                    _functionObject.OwningDataSeries = null;
                _functionObject = value;
                if (value != null)
                {
                    _function = new DrawableFunction(value.Compute);
                    value.OwningDataSeries = this;
                }
                if (PlotterControl != null)
                    PlotterControl.Invalidate();
            }
        }

        private Point[] _linesToDraw;

        public override void Paint(Graphics gr)
        {
            if (PlotterControl == null)
                throw new InvalidOperationException("PlotterControl is null");
            if (_function == null)
                return;

            int clientWidth = PlotterControl.ClientRectangle.Width;
            if (_linesToDraw == null ||
                _linesToDraw.Length != PlotterControl.ClientRectangle.Width)
                _linesToDraw = new Point[PlotterControl.ClientRectangle.Width];

            for (int screenX = 0; screenX < clientWidth; screenX++)
            {
                double spaceX = PlotterControl.ScreenX2SpaceX(screenX);
                double spaceY = _function(spaceX);
                int screenY = PlotterControl.SpaceY2ScreenY(spaceY);
                _linesToDraw[screenX] = new Point(screenX, screenY);
            }

            using (Pen pen = new Pen(ForeColor, LineWidth))
            {
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                gr.DrawLines(pen, _linesToDraw);
            }
        }

    }
}
