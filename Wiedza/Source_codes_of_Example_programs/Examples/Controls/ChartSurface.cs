using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Controls
{
    public partial class ChartSurface : BorderedControl
    {
        [Flags]
        public enum Axes
        {
            None = 0,
            Horizontal = 1,
            Vertical = 2,
            Both = Horizontal | Vertical
        }

        public ChartSurface()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        [DefaultValue(typeof(System.Drawing.Color), "Window")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        [DefaultValue(typeof(System.Drawing.Color), "WindowText")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; }
        }

        private Axes _axesVisibility = Axes.Both;

        [Category("Appearance"), DefaultValue(Axes.Both)]
        public Axes AxesVisibility
        {
            get { return _axesVisibility; }
            set
            {
                _axesVisibility = value;
                Invalidate();
            }
        }

        private Axes _ticksVisibility = Axes.Both;

        [Category("Appearance"), DefaultValue(Axes.Both)]
        public Axes TicksVisibility
        {
            get { return _ticksVisibility; }
            set
            {
                _ticksVisibility = value;
                Invalidate();
            }
        }

        private RectangleF _visibleRectangle
            = new RectangleF(-10.0f, -10.0f, 20.0f, 20.0f);

        public RectangleF VisibleRectangle
        {
            get { return _visibleRectangle; }
            set
            {
                _visibleRectangle = value;
                Invalidate();
            }
        }

        private float _tickDistance = 1.0f;

        [Category("Appearance"), DefaultValue(1.0f)]
        public float TickDistance
        {
            get { return _tickDistance; }
            set
            {
                _tickDistance = value;
                Invalidate();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Invalidate();
            base.OnSizeChanged(e);
        }

        [Category("Behavior"), DefaultValue(true)]
        public new bool DoubleBuffered
        {
            get { return base.DoubleBuffered; }
            set { base.DoubleBuffered = value; }
        }

        public static double TransformSpace(double a1, double b1,
            double a2, double b2, double x)
        {
            // f(screenX) = scale*screenX + offset
            double scale = (b2 - a2) / (b1 - a1);
            double offset = a2 - scale * a1;
            return scale * x + offset;
        }

        public int SpaceX2ScreenX(double x)
        {
            return (int)Math.Round(TransformSpace(
                    _visibleRectangle.Left, _visibleRectangle.Right,
                    0, ClientSize.Width, x));
        }

        public int SpaceY2ScreenY(double y)
        {
            // We reverse the y0 axis.
            return (int)Math.Round(TransformSpace(
                    _visibleRectangle.Top, _visibleRectangle.Bottom,
                    ClientSize.Height, 0, y));
        }

        public Point Space2Screen(PointF point)
        {
            return new Point(SpaceX2ScreenX(point.X), SpaceY2ScreenY(point.Y));
        }

        public double ScreenX2SpaceX(int x)
        {
            return TransformSpace(
                0, ClientSize.Width,
                _visibleRectangle.Left, _visibleRectangle.Right, x);
        }

        public double ScreenY2SpaceY(int y)
        {
            return TransformSpace(
                ClientSize.Height, 0,
                _visibleRectangle.Top, _visibleRectangle.Bottom, y);
        }

        public PointF Screen2Space(Point point)
        {
            return new PointF((float)ScreenX2SpaceX(point.X),
                (float)ScreenY2SpaceY(point.Y));
        }

        protected void DrawHorizontalAxis(Pen pen, Graphics gr)
        {
            int y0 = SpaceY2ScreenY(0.0);
            gr.DrawLine(pen, 0, y0, ClientSize.Width - 1, y0);
        }

        protected void DrawVerticalAxis(Pen pen, Graphics gr)
        {
            int x0 = SpaceX2ScreenX(0.0);
            gr.DrawLine(pen, x0, 0, x0, ClientSize.Height - 1);
        }

        protected void DrawHorizontalTicks(Pen pen, Graphics gr,
            bool top, bool bottom, bool axis)
        {
            // Calculate the first and last tick number.
            int firstTickNumber =
                (int)Math.Ceiling(_visibleRectangle.Left / _tickDistance);
            int lastTickNumber =
                (int)Math.Floor(_visibleRectangle.Right / _tickDistance);

            // Calculate the horizontal axis position.
            int axisPos = SpaceY2ScreenY(0.0);

            // Draw the ticks.
            for (int tick = firstTickNumber; tick <= lastTickNumber; tick++)
            {
                int tickPosition = SpaceX2ScreenX(tick * _tickDistance);
                if (top)
                    gr.DrawLine(pen, tickPosition, 0,
                        tickPosition, 2);
                if (bottom)
                    gr.DrawLine(pen, tickPosition, ClientSize.Height - 1,
                        tickPosition, ClientSize.Height - 3);
                if (axis)
                    gr.DrawLine(pen, tickPosition, axisPos - 1,
                        tickPosition, axisPos + 1);
            }
        }

        protected void DrawVerticalTicks(Pen pen, Graphics gr,
            bool left, bool right, bool axis)
        {
            // Calculate the first and last tick number.
            int firstTickNumber =
                (int)Math.Ceiling(_visibleRectangle.Top / _tickDistance);
            int lastTickNumber =
                (int)Math.Floor(_visibleRectangle.Bottom / _tickDistance);

            // Calculate the vertical axis position.
            int axisPos = SpaceX2ScreenX(0.0);

            // Draw the ticks.
            for (int tick = firstTickNumber; tick <= lastTickNumber; tick++)
            {
                int tickPosition = SpaceY2ScreenY(tick * _tickDistance);
                if (left)
                    gr.DrawLine(pen, 0, tickPosition,
                        2, tickPosition);
                if (right)
                    gr.DrawLine(pen, ClientSize.Width - 1, tickPosition,
                        ClientSize.Width - 3, tickPosition);
                if (axis)
                    gr.DrawLine(pen, axisPos - 1, tickPosition,
                        axisPos + 1, tickPosition);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using (Pen pen = new Pen(ForeColor))
            {
                bool hasHorizontalAxis = (_axesVisibility & Axes.Horizontal) != 0;
                bool hasVerticalAxis = (_axesVisibility & Axes.Vertical) != 0;
                bool hasHorizontalTicks = (_ticksVisibility & Axes.Horizontal) != 0;
                bool hasVerticalTicks = (_ticksVisibility & Axes.Vertical) != 0;

                if (hasHorizontalAxis)
                    DrawHorizontalAxis(pen, pe.Graphics);
                if (hasVerticalAxis)
                    DrawVerticalAxis(pen, pe.Graphics);

                if (hasHorizontalTicks)
                    DrawHorizontalTicks(pen, pe.Graphics,
                        true, true, hasHorizontalAxis);
                if (hasVerticalTicks)
                    DrawVerticalTicks(pen, pe.Graphics,
                        true, true, hasVerticalAxis);
            }
        }
    }
}
