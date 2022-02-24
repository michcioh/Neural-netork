using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Controls
{
    public partial class CoordinateSystem : UserControl
    {
        private int height, width, centerx, centery, scale;
        private Bitmap buffImage;

        public CoordinateSystem()
        {
            InitializeComponent();          
        }

        private int ccoX(double x)
        {
	        return (int)(centerx + x*scale);
        }

        private int ccoY(double y) 
        {
	        return (int)(centery - y*scale);
        }

        private double occX(double x)
        {
	        return (x-centerx)/(double)scale;
        }

        private double occY(double y)
        {
	        return (centery-y)/(double)scale;
        }

        public void drawCoordinates()
        {         
            Graphics g = Graphics.FromImage(buffImage);
            g.Clear(Color.White);            
            Pen myPen = new Pen(Color.Black, 1);
            g.DrawLine(myPen, 0, centery, width, centery);
            g.DrawLine(myPen, centerx, 0, centerx, height);
            myPen.Dispose();
        }

        public void drawLogisticCurve(double beta, Color color)
        {
            Graphics g = Graphics.FromImage(buffImage);
            Pen myPen = new Pen(color, 2);	        
	                
	        double Start, End, move, currX, currY, nextX, nextY;
            move = 1.0 / scale;
	        Start = occX (0);
	        End = occX (width);
	        currX = Start;            
	        currY = LogisticFunction (currX, beta);
	        while ( currX + move <= End )
	        {
            nextX = currX + move;
            nextY = LogisticFunction( nextX , beta);
            g.DrawLine(myPen, ccoX(currX), ccoY(currY), ccoX(nextX), ccoY(nextY));
            currX = nextX;
            currY = nextY;
	        }
            myPen.Dispose();
        }

        public void drawTanh(double bias, Color color)
        {
            Graphics g = Graphics.FromImage(buffImage);
            Pen myPen = new Pen(color, 2);

            double Start, End, move, currX, currY, nextX, nextY;
            move = 1.0 / scale;
            Start = occX(0);
            End = occX(width);
            currX = Start;
            currY = TanhFunction(currX, bias);
            while (currX + move <= End)
            {
                nextX = currX + move;
                nextY = TanhFunction(nextX, bias);
                g.DrawLine(myPen, ccoX(currX), ccoY(currY), ccoX(nextX), ccoY(nextY));
                currX = nextX;
                currY = nextY;
            }
            myPen.Dispose();
        }

        public void drawActivationFunction(double x, Color color)
        {                       
            Graphics g = Graphics.FromImage(buffImage);
            Pen myPen = new Pen(color, 2);
            int pointx = centerx + (int) (x * scale);
            g.DrawLine(myPen, 0, centery + scale, pointx, centery + scale);
            g.DrawLine(myPen, pointx, centery + scale, pointx, centery - scale);
            g.DrawLine(myPen, pointx, centery - scale, width, centery - scale);
            myPen.Dispose();            
        }

        public void createBufferedImage(int width, int height)
        {
            this.width = width;
            this.height = height;
            centerx = width / 2;
            centery = height / 2;
            scale = height / 2 - 20;
            buffImage = new Bitmap(width, height);
        }

        private void CoordinateSystem_Paint(object sender, PaintEventArgs pe)
        {
            if (buffImage != null)
            pe.Graphics.DrawImage(buffImage, 0, 0);
        }

        /////////////////functions//////////////////

        private double LogisticFunction(double x, double beta)
        {
            double result;
            result = 2.0 / (1.0 + Math.Exp(-beta *x)) - 1;
            return result;
        }

        private double TanhFunction(double x, double bias)
        {
            double result;
            result = Math.Tanh(x-bias);
            return result;
        }
    }
}
