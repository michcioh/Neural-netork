using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example11
{
    public partial class Simulation : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;
        private Color empty = Color.LightYellow;
        private Pen pen;
        private Graphics g;
        private int _quarter;
        private Rectangle rect=new Rectangle();
        private Random _rndGenerator = new Random();
        private double _shortFactorX;
        private double _shortFactorY;
        double[] points = new double[2];
      
           
        internal Simulation(ProgramLogic programLogic)
        {
            InitializeComponent();
            
            imgBitmap.Image = new Bitmap(imgBitmap.Width, imgBitmap.Height);
            g = Graphics.FromImage(imgBitmap.Image);
            pen = new Pen(Color.Black);
            g.Clear(empty);
          
            _programLogic = programLogic;
            _quarter = 0;

            rect.Width = 125;
            rect.Height = 125;
            _programLogic.Distribution = 3;

            _shortFactorX = rect.Width / 20.0;// *0.99;
            _shortFactorY = rect.Height / 20.0;// *0.99;

            uiDistribution.SelectedIndex = 0;

            uiNeighbour.Value = Convert.ToDecimal(_programLogic.Neighbour);
            
        }

        public override bool IsFirst
        {
            get { return false; }
        }

        public override WizardPanel GetPrevious()
        {
            return new SetUp(_programLogic);
        }

        public override bool IsLast
        {
            get { return true; }
        }

        public int FixX(double x,int quarter)
        {           
            
            int _x = rect.Width / 2 + Convert.ToInt16(x * _shortFactorX);

            if (quarter >= 5)
                quarter -= 5;
            
           _x = _x+ 10 + quarter * (rect.Width + 10);
           return _x; 
        }

        public int FixY(double y,int quarter)
        {
            int _y = rect.Height / 2 - Convert.ToInt16(y * _shortFactorY);
            if (quarter < 5)
                _y = _y + 10;
            else
                _y = _y+ 20 + rect.Height;

            return _y;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            _programLogic.Iteractions += Convert.ToUInt16(uiIteractions.Value);
            _programLogic.Distribution = uiDistribution.SelectedIndex + 1;
            _programLogic.Alpha0 = Convert.ToDouble(uiAlpha0.Value);
            _programLogic.Alpha1 = Convert.ToDouble(uiAlpha1.Value);
            _programLogic.Neighbour = Convert.ToDouble(uiNeighbour.Value);
            _programLogic.EspAlpha = Convert.ToDouble(uiEspAlpha.Value);
            _programLogic.EspNeighbour = Convert.ToDouble(uiEspNeighbour.Value);

            draw_view(5, Color.YellowGreen, 1);
            for (int i = 0; i < uiIteractions.Value; i++)
            {
                points=randomPoint(_programLogic.Distribution);
                _programLogic.PerformTeaching(points);
                _programLogic.Alpha0 = _programLogic.Alpha0 * _programLogic.EspAlpha;
                _programLogic.Alpha1 = _programLogic.Alpha1 * _programLogic.EspAlpha;
                _programLogic.Neighbour = (_programLogic.Neighbour - 1) * _programLogic.EspNeighbour + 1;
            }

            label4.Text = Convert.ToString(_programLogic.Iteractions);
           
            draw_view(_quarter-1, Color.Purple,0);

            if (_quarter == 5)
                _quarter++;

            if (_quarter > 9)
                _quarter = 6;
            
            draw_view(_quarter,Color.Red,1);
            draw_net(_quarter);
            _quarter++;
            
            imgBitmap.Refresh();                       
        }

        private double[] randomPoint(int distribution)
        {
            double[] points = new double[2];

            points[0] = 20 * _rndGenerator.NextDouble() - 10;
            points[1] = 20 * _rndGenerator.NextDouble() - 10;

            //to avoid border overlapping
            points[0] *= 0.98;
            points[1] *= 0.98;

            switch (distribution)
            {
                case 2:
                    {
                        points[1] = points[1] / 3.0;
                        if (points[0] >= -10 && points[0] < 2)
                            points[0] = (points[0] + 4) * 5.0 / 3.0;
                        else
                            if (points[0] >= 2 && points[0] < 6)
                        {
                            points[0] = (points[0] - 4) * 5.0 / 3.0;
                            points[1] = points[1] + 20 / 3.0;
                        }
                        else
                            if (points[0] >= 6 && points[0] <= 10)
                        {
                            points[0] = (points[0] - 8) * 5.0 / 3.0;
                            points[1] = points[1] - 20 / 3.0;
                        }
                        break;
                    }
                case 3:
                    {
                        points[1] = (points[1] - 10) / 2.0;
                        if (points[1] > (2 * points[0] + 10))
                        {
                            points[1] = -points[1];
                            points[0] = -10 - points[0];
                        }
                        if (points[1] > (-2 * points[0] + 10))
                        {
                            points[1] = -points[1];
                            points[0] = 10 - points[0];
                        }
                        break;
                    }
                default:               
                break;
            }

            g.DrawEllipse(new Pen(Color.Green),
               FixX(points[0],5)-1,FixY(points[1],5)-1 , 3, 3);

            _programLogic.TeachingElement.Inputs[0] = points[0];
            _programLogic.TeachingElement.Inputs[1] = points[1];

            return points;
        }

        private void draw_view(int quarter,Color col,int clear)
        {
            if (quarter == -1)
                quarter++;

            rect.X=FixX(-10,quarter);
            rect.Y=FixY(10,quarter);
            if (clear == 1)
                g.FillRectangle(new SolidBrush(empty), rect.X-2,
                    rect.Y-2, rect.Width + 4 ,rect.Height + 4 );
            
            g.DrawRectangle(new Pen(col), rect);

            imgBitmap.Refresh();
        }

        private void draw_net(int quarter)
        {
            Point p1 = new Point();
            Point p2 = new Point();
           
            for ( int i=0; i < _programLogic.NetSizeX ; i++ )
                for (int j = 0; j < _programLogic.NetSizeY; j++)
                {
                    p1.X = FixX(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i, j)].Weights[0], quarter);
                    p1.Y = FixY(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i, j)].Weights[1], quarter);

                    if (i < _programLogic.NetSizeX-1)
                    {
                        p2.X=FixX(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i+1, j)].Weights[0], quarter);
                        p2.Y=FixY(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i+1, j)].Weights[1], quarter);

                        g.DrawLine(new Pen(Color.Red), p1, p2);                    
                    }
                    
                    if (j < _programLogic.NetSizeY-1)
                    {
                        p2.X = FixX(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i , j + 1 )].Weights[0], quarter);
                        p2.Y = FixY(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i , j + 1 )].Weights[1], quarter);

                        g.DrawLine(new Pen(Color.Red), p1, p2); 
                    }

                    //g.DrawEllipse(new Pen(Color.Blue), p1.X-1, p1.Y-1, 3, 3);
                }

            for (int i = 0; i < _programLogic.NetSizeX; i++)
                for (int j = 0; j < _programLogic.NetSizeY; j++)
                {
                    p1.X = FixX(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i, j)].Weights[0], quarter);
                    p1.Y = FixY(_programLogic.ExaminedNetwork.Neurons[_programLogic._MapIndex(i, j)].Weights[1], quarter);

                    g.DrawEllipse(new Pen(Color.Blue),
                      p1.X - 1, p1.Y - 1, 3, 3);
                }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _programLogic.LoadTeachingSet(
                _programLogic.NetSizeX,
                _programLogic.NetSizeY,
                _programLogic.InitialWeights);
            g.Clear(empty);
            imgBitmap.Refresh();
            _programLogic.Iteractions = 0;
            label4.Text = "0";
            _quarter = 0;
        }

        private void uiEspAlpha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void uiAlpha0_ValueChanged(object sender, EventArgs e)
        {

        }






    }
}

