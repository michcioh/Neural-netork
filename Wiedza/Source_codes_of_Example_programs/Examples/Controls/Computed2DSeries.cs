using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace RTadeusiewicz.NN.Controls
{
    public class Computed2DSeries : DataSeries
    {
        public delegate Color DrawableFunction(double x, double y);

        public abstract class ParametrizedFunction
        {
            private Computed2DSeries _owningDataSeries;

            public Computed2DSeries OwningDataSeries
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

            public abstract Color Compute(double x, double y);
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

        public override void Paint(System.Drawing.Graphics gr)
        {
            if (PlotterControl == null)
                throw new InvalidOperationException("PlotterControl is null");
            if (_function == null)
                return;

            int screenWidth = PlotterControl.ClientRectangle.Width;
            int screenHeight = PlotterControl.ClientRectangle.Height;
            Bitmap bmp = new Bitmap(screenWidth, screenHeight,
                PixelFormat.Format32bppArgb);

            Rectangle wholeBitmap = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(wholeBitmap,
                ImageLockMode.WriteOnly, bmp.PixelFormat);
            try
            {
                int strideAbs = Math.Abs(bmpData.Stride);
                bool bottomUp = bmpData.Stride < 0;
                byte[] bmpBuf = new byte[strideAbs * bmpData.Height];
                int scanLine = 0;
                int yFirst = bottomUp ? bmpData.Height - 1 : 0;
                int yAfterLast = bottomUp ? -1 : bmpData.Height;
                int dy = bottomUp ? -1 : 1;
                for (int screenY = yFirst;
                    screenY != yAfterLast;
                    screenY += dy, scanLine += strideAbs)
                {
                    double y = PlotterControl.ScreenY2SpaceY(screenY);
                    int pixelIndex = scanLine;
                    for (int screenX = 0; screenX < bmpData.Width; screenX++)
                    {
                        double x = PlotterControl.ScreenX2SpaceX(screenX);
                        Color col = _function(x, y);
                        bmpBuf[pixelIndex++] = col.B;
                        bmpBuf[pixelIndex++] = col.G;
                        bmpBuf[pixelIndex++] = col.R;
                        bmpBuf[pixelIndex++] = col.A;
                    }
                }
                System.Runtime.InteropServices.Marshal.Copy(bmpBuf, 0, bmpData.Scan0,
                    bmpBuf.Length);
            }
            finally
            {
                bmp.UnlockBits(bmpData);
            }

            /*for (int screenY = 0; screenY < screenHeight; screenY++)
            {
                double y = PlotterControl.ScreenY2SpaceY(screenY);
                for (int screenX = 0; screenX < screenWidth; screenX++)
                {
                    double x = PlotterControl.ScreenX2SpaceX(screenX);
                    bmp.SetPixel(screenX, screenY, _function(x, y));
                }
            }*/

            gr.DrawImage(bmp, 0, 0);
        }
    }
}
