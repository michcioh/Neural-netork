using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;


namespace RTadeusiewicz.NN.Example10a
{
    public partial class Simulation : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;
        private Pen pen;
        private Graphics g;
        private Point p = Point.Empty;
        private Color empty = Color.LightYellow;
        private int waitTime = 3000;
        private double _shortFactor = 20;
        private int _step = 1;

        internal Simulation(ProgramLogic programLogic)
        {
            InitializeComponent();
            _programLogic = programLogic;
            _shortFactor = imgBitmap.Height / 20;
            imgBitmap.Image = new Bitmap(imgBitmap.Width,imgBitmap.Height);
            g = Graphics.FromImage(imgBitmap.Image);
            pen = new Pen(Color.Black);
            g.Clear(empty);
            drawCoordinate();
            drawWeights(true);
            label2.Text = "Click a quarter for learning object";
            
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

        public int FixX(int x)
        {
            return imgBitmap.Width/2 +  x;
        }

        public int FixY(int y)
        {
            return imgBitmap.Height / 2 - y;
        }

        public Int32 FixDouble(double i)
        {
            int k;
            try
            {
                k = Convert.ToInt32(i * _shortFactor);
            }
            catch
            {
                k = 0;
            }
            return k;
        }

       
        private void Experiment(int _quarter, int _step)
        {
            int[,] _teacher = new int[4, 2] { { 5, 5 }, { -5, 5 }, { -5, -5 }, { 5, -5 } };

             switch (_step)
             {
                 case 1:
                     {
                         _programLogic.TeachingElement.Inputs[0] = _teacher[_quarter - 1, 0];
                         _programLogic.TeachingElement.Inputs[1] = _teacher[_quarter - 1, 1];

                         _programLogic.PerformTeaching();
                         _programLogic.PerformExperiment(_programLogic.TeachingElement.Inputs);

                         g.Clear(empty);
                         drawCoordinate();
                         drawTeacher();
                         drawResponse();
                         //drawWeights(true);
                         imgBitmap.Refresh();
                         break;
                     }
                 case 2:
                     {
                         //_programLogic.PerformTeaching();
                         //_programLogic.PerformExperiment(_programLogic.TeachingElement.Inputs);
                         drawStimulate();
                         drawResponse();
                         drawWeights(false);
                         imgBitmap.Refresh();
                         break;
                     }
                 case 3:
                     {
                         //Thread.Sleep(waitTime);
                         g.Clear(empty);
                         drawCoordinate();
                         drawWeights(true);
                         imgBitmap.Refresh();
                         break;
                     }
             }
        }

        //Rysowanie osi wspolrzednych
        public void drawCoordinate()
		{
			pen.Color =Color.Black;
            g.DrawLine(pen, 0, imgBitmap.Height / 2, 
                imgBitmap.Width, imgBitmap.Height / 2);
            g.DrawLine(pen, imgBitmap.Width / 2, 0,
                imgBitmap.Width / 2, imgBitmap.Height);
		}

        //Rysowanie lini pomiedzy starym a nowymo polozeniem
        public void drawStimulate()
        {
            int x, y;
            int x1, y1;
            Pen _pen;

            _pen = new Pen(Color.Black);

            //ustalenie nowego polozenia neuronow
            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                
                x = FixX(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].Weights[0]));
                y = FixY(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].Weights[1]));

                x1 = FixX(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].PrevWeights[0]));
                y1 = FixY(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].PrevWeights[1]));

                if ((x1 > -1) && (x1 < imgBitmap.Width + 1) && (y1 > -1) && (y1 < imgBitmap.Height + 1))
                {
                    _pen.DashStyle =DashStyle.Dash;                  
                    g.DrawLine(_pen, x, y, x1, y1);                   
                }
            }
        }

        //Rysowanie wag neuronow oraz odpowiedzi neuronow(kolory)
        public void drawResponse()
        {

            int x, y;
            double max = 0;
            double response;
			//rysowanie pobudzenia neuronow, w zaleznosci o wartosci, sa rozne kolory
            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                response = _programLogic.CurrentResponse[i];
                if (Math.Abs(response) > max)
                    max = response;
            }
            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                response=_programLogic.CurrentResponse[i];                
                pen.Color = Color.Red;

                if (response < 0) 
                    pen.Color = Color.Blue;
                if (Math.Abs(response) < 0.2 * max) 
                    pen.Color = Color.DarkGray;

                x = FixX(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].PrevWeights[0]));
                y = FixY(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].PrevWeights[1]));

                _draw(x, y, pen);
            }
            pen.Color = Color.Black;            
        }

        //Rysowanie wag neuronow
        public void drawWeights(bool _solid)
        {
            int x, y;
            pen.Color = Color.Black;            
               
            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                x = FixX(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].Weights[0]));
                y = FixY(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].Weights[1]));
                if (_solid)
                    _draw(x, y, pen);
                else
                    _draw2(x, y, pen);
            }
        }

        //Rysowanie obiktu uczacego
        public void drawTeacher()
        {
            int x, y;
            pen.Color = Color.Green;

            x = FixX(FixDouble(_programLogic.TeachingElement.Inputs[0]));
            y = FixY(FixDouble(_programLogic.TeachingElement.Inputs[1]));

            _draw(x, y, pen);               
        }

        // Rysowanie
        public void _draw(int x, int y,Pen _pen)
        {
            if ((x > -1) && (x < imgBitmap.Width + 1) && (y > -1) && (y < imgBitmap.Height + 1))
            {
                if (_pen.Color==Color.Green)
                    g.FillRectangle(new SolidBrush(_pen.Color), x - 3, y - 3, 6, 6);
                else
                    g.FillRectangle(new SolidBrush(_pen.Color), x - 2, y - 2, 4, 4);
            }
        }

        // Rysowanie puste
        public void _draw2(int x, int y, Pen _pen)
        {
            if ((x > -1) && (x < imgBitmap.Width + 1) && (y > -1) && (y < imgBitmap.Height+1))
            {
                g.DrawRectangle(_pen, x - 2, y - 2, 4, 4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            _programLogic._randomGenerator.RewindTable();
            _programLogic.InitializeTeaching();
            g.Clear(empty);
            drawCoordinate();
            drawWeights(true);
            imgBitmap.Refresh();
            _step = 1;
            btNext.Visible = false;
            label2.Text = "Click a quarter for learning object";
            
        }

        // Detekcja klikniêcia
        private void imgBitmap_Click(object sender, EventArgs e)
        {
            int _x = (e as MouseEventArgs).X;
            int _y = (e as MouseEventArgs).Y;

            int _quarter=0;

            if ( _x >= imgBitmap.Width / 2 && _y < imgBitmap.Height / 2)
                _quarter = 1;
            if (_x < imgBitmap.Width / 2 && _y < imgBitmap.Height / 2)
                _quarter = 2;
            if (_x < imgBitmap.Width / 2 && _y >= imgBitmap.Height / 2)
                _quarter = 3;
            if (_x >= imgBitmap.Width / 2 && _y >= imgBitmap.Height / 2)
                _quarter = 4;

            if (_step == 1)
            {
                Experiment(_quarter, _step++);
                btNext.Visible = true;
                label2.Text = "Press Continue"; 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int _x = (e as MouseEventArgs).X;
            int _y = (e as MouseEventArgs).Y;

            int _quarter = 0;

            if (_x >= imgBitmap.Width / 2 && _y < imgBitmap.Height / 2)
                _quarter = 1;
            if (_x < imgBitmap.Width / 2 && _y < imgBitmap.Height / 2)
                _quarter = 2;
            if (_x < imgBitmap.Width / 2 && _y >= imgBitmap.Height / 2)
                _quarter = 3;
            if (_x >= imgBitmap.Width / 2 && _y >= imgBitmap.Height / 2)
                _quarter = 4;

            Experiment(_quarter, _step++);

            if (_step > 3)
            {
                _step = 1;
                btNext.Visible = false;
                label2.Text = "Click a quarter for learning object";
            }
        }


        
    }
}

