using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RTadeusiewicz.NN.Controls
{
    public class PointDataSeries : DataSeries
    {
        public enum PointShape { Square, Circle }

        public struct ChartPoint
        {
            public PointF Coords;
            public Color Color;
            public bool DrawLines;
            public PointShape Shape;
            public ChartPoint(PointF coords, Color color, bool drawLines)
                : this(coords, color, drawLines, PointShape.Circle) { }
            public ChartPoint(PointF coords, bool drawLines)
                : this(coords, Color.Empty, drawLines, PointShape.Circle) { }
            public ChartPoint(PointF coords, Color color, bool drawLines,
                PointShape shape)
            {
                Coords = coords;
                Color = color;
                DrawLines = drawLines;
                Shape = shape;
            }
        }

        public PointDataSeries(int capacity)
        {
            _points = new NotifyingList<ChartPoint>(capacity);
            _points.Change += new EventHandler(_points_Change);
        }

        public PointDataSeries() : this(0) { }

        private NotifyingList<ChartPoint> _points;

        public NotifyingList<ChartPoint> Points
        {
            get { return _points; }
        }

        private void _points_Change(object sender, EventArgs e)
        {
            if (PlotterControl != null)
                PlotterControl.Invalidate();
        }
        private int _pointSize = 2;

        public int PointSize
        {
            get { return _pointSize; }
            set
            {
                _pointSize = value;
                if (PlotterControl != null)
                    PlotterControl.Invalidate();
            }
        }

        public override void Paint(Graphics gr)
        {
            if (PlotterControl == null)
                throw new InvalidOperationException("PlotterControl is null");

            int diameter = 2 * PointSize;
            Point origin = PlotterControl.Space2Screen(new PointF(0.0f, 0.0f));

            using (Pen pen = new Pen(ForeColor, LineWidth))
            {
                foreach (ChartPoint point in _points)
                {
                    /* Point is a structure, so we can afford it. If it were a class,
                     * this would be very memory-consuming. */
                    Point sigPoint = PlotterControl.Space2Screen(point.Coords);
                    pen.Color =
                        (point.Color == Color.Empty) ? ForeColor : point.Color;

                    switch (point.Shape)
                    {
                        case PointShape.Circle:
                            gr.DrawEllipse(pen,
                                sigPoint.X - _pointSize,
                                sigPoint.Y - _pointSize,
                                diameter, diameter);
                            break;
                        case PointShape.Square:
                            gr.DrawRectangle(pen,
                                sigPoint.X - _pointSize,
                                sigPoint.Y - _pointSize,
                                diameter, diameter);
                            break;
                    }

                    if (point.DrawLines)
                    {
                        // Draw the dashed line from the origin to the signal point.
                        pen.DashStyle = DashStyle.Dash;
                        gr.DrawLine(pen, origin, sigPoint);

                        /* Draw the dotted lines from the signal point to the axes.
                         * The line is drawn not strictly from the signal point, but
                         * from the ellipse'point boundary. The Math.Sign method allows
                         * us to support the both axis sides correctly. */
                        pen.DashStyle = DashStyle.Dot;
                        gr.DrawLine(pen,
                            sigPoint.X,
                            sigPoint.Y + _pointSize * Math.Sign(point.Coords.Y),
                            sigPoint.X, origin.Y);
                        gr.DrawLine(pen,
                            sigPoint.X - _pointSize * Math.Sign(point.Coords.X),
                            sigPoint.Y,
                            origin.X, sigPoint.Y);

                        // Restore the original DashStyle settings.
                        pen.DashStyle = DashStyle.Solid;
                    }
                }
            }
        }

    }
}
