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


namespace RTadeusiewicz.NN.Example10b
{
    public partial class Simulation : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;
        private Pen pen;
        private Graphics g;
        private Point p = Point.Empty;
        private Color empty = Color.LightYellow;
        private double _shortFactor = 20;
        private Random _rndGenerator = new Random();
       // private int delay = 100;
        private int step = 0;
        private int semi_step = 0;
        private int _quarterTmp;
        private int d = 5;
        


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
            label2.Text = "Press/Hold Start";
            _programLogic.Teachers[0] = 0;
            _programLogic.Teachers[1] = 0;
            _programLogic.Teachers[2] = 0;
            _programLogic.Teachers[3] = 0;
            _programLogic.Teachers_9[0] = 0;
            _programLogic.Teachers_9[1] = 0;
            _programLogic.Teachers_9[2] = 0;
            _programLogic.Teachers_9[3] = 0;

            _programLogic.Ranges[0] = 0;
            _programLogic.Ranges[1] = 0;
            _programLogic.Ranges[2] = 0;
            _programLogic.Ranges[3] = 0;
            semi_step = 0;

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

        public Int32 Conv(double i)
        {
            int k;
            try
            {
                k = Convert.ToInt32(i);
            }
            catch
            {
                k = 0;
            }
            return k;
        }

       
        private void Experiment(int _quarter, int _step, bool _rnd)
        {
            int x, y;
            int[,] _teacher = new int[4, 2] { { 1, 1 }, { -1, 1 }, { -1, -1 }, { 1, -1 } };

             switch (_step)
             {
                 case 1:
                     {
                         if (_rnd)
                         {
                             //x = Convert.ToInt32(18 * _rndGenerator.NextDouble() - 9);
                             //y = Convert.ToInt32(18 * _rndGenerator.NextDouble() - 9);
                             x = _teacher[_quarter, 0] * Convert.ToInt32(9 * _rndGenerator.NextDouble());
                             y = _teacher[_quarter, 1] * Convert.ToInt32(9 * _rndGenerator.NextDouble());
                         }
                         else
                         {
                             x = _teacher[_quarter, 0]*d;
                             y = _teacher[_quarter, 1]*d;
                         }

                         if (x >= 0 && y >= 0) _programLogic.Teachers[0]++;
                         if (x < 0 && y >= 0) _programLogic.Teachers[1]++;
                         if (x < 0 && y < 0) _programLogic.Teachers[2]++;
                         if (x >= 0 && y < 0) _programLogic.Teachers[3]++;

                         if (_programLogic.NumberOfRuns < 9)
                         {
                             _programLogic.Teachers_9[0] = _programLogic.Teachers[0];
                             _programLogic.Teachers_9[1] = _programLogic.Teachers[1];
                             _programLogic.Teachers_9[2] = _programLogic.Teachers[2];
                             _programLogic.Teachers_9[3] = _programLogic.Teachers[3];
                         }

                         _programLogic.NumberOfRuns++;

                         _programLogic.TeachingElement.Inputs[0] = x;
                         _programLogic.TeachingElement.Inputs[1] = y;

                         g.Clear(empty);
                         drawText();
                         drawCoordinate();
                         drawTeacher();
                         drawWeights(true);
                         imgBitmap.Refresh();
                         break;
                     }
                 case 2:
                     {
                         _programLogic.PerformTeaching();
                         _programLogic.PerformExperiment(_programLogic.TeachingElement.Inputs);
                         
                         //drawText();
                         drawStimulate();
                         drawResponse();
                         drawWeights(false);
                         imgBitmap.Refresh();
                         break;
                     }
                 case 3:
                     {
                         g.Clear(empty);
                         drawText();
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

        public void drawText()
        {
            int x, y;
            _programLogic.Ranges[0] = 0;
            _programLogic.Ranges[1] = 0;
            _programLogic.Ranges[2] = 0;
            _programLogic.Ranges[3] = 0;

            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                x = Conv(_programLogic.ExaminedNetwork.Neurons[i].Weights[0]);
                y = Conv(_programLogic.ExaminedNetwork.Neurons[i].Weights[1]);

                if (x >= 0 && y >= 0) _programLogic.Ranges[0]++;
                if (x < 0 && y >= 0) _programLogic.Ranges[1]++;
                if (x < 0 && y < 0) _programLogic.Ranges[2]++;
                if (x >= 0 && y < 0) _programLogic.Ranges[3]++;

            }

            Font fn = new Font("System", 8, FontStyle.Bold);

            // I
            String s =_programLogic.Teachers[0].ToString() + "("+
                _programLogic.Teachers_9[0].ToString() + 
                "), " +_programLogic.Ranges[0].ToString();                       
            g.DrawString(s, fn, new SolidBrush(Color.Black), imgBitmap.Width - 75, 2);

            // II
            s = _programLogic.Teachers[1].ToString() + "(" +
                 _programLogic.Teachers_9[1].ToString() +
                "), " + _programLogic.Ranges[1].ToString();          
            g.DrawString(s, fn, new SolidBrush(Color.Black), 2, 2);
           
            // III
            s = _programLogic.Teachers[2].ToString() + "(" +
                 _programLogic.Teachers_9[2].ToString() +
                 "), " + _programLogic.Ranges[2].ToString();
             g.DrawString(s, fn, new SolidBrush(Color.Black), 2, imgBitmap.Height - 20);

           
            // IV
             s = _programLogic.Teachers[3].ToString() + "(" +
                  _programLogic.Teachers_9[3].ToString() +
                "), " + _programLogic.Ranges[3].ToString();
            g.DrawString(s, fn, new SolidBrush(Color.Black), imgBitmap.Width - 75,
                    imgBitmap.Height - 20);

        }

        //Rysowanie wag neuronow oraz odpowiedzi neuronow(kolory)
        public void drawResponse()
        {

            int x, y;
            double max = 0;
            double response;
            double[] _response = new double[_programLogic.NumberOfNeurons];

			//rysowanie pobudzenia neuronow, w zaleznosci o wartosci, sa rozne kolory
            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                response = _programLogic.CurrentResponse[i];

                _response[i] = 4 * response / _programLogic.Power[i];
                if (Math.Abs(_response[i]) > max)
                    max = _response[i];
            }
           
            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                response = _response[i];

              //  response = 4 * response / _programLogic.Power[i];

              //_programLogic.Power[i] = 0;


                
                /////////////////////

                pen.Color = Color.Red;
                if (response < 0.2 * max)
                    response = 0.3 * response;

                if (response < 0)
                    response = 0.1 * response;

              //  if (response < 0.2 * max)
               //     pen.Color = Color.DarkGray;

                if (response < 0) 
                    pen.Color = Color.Blue;


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
            _programLogic.RestoreEthaFactor();
            g.Clear(empty);
            drawCoordinate();
            drawWeights(true);
            imgBitmap.Refresh();
            label2.Text = "Choose a quarter for learning object";

            _programLogic.Teachers[0] = 0;
            _programLogic.Teachers[1] = 0;
            _programLogic.Teachers[2] = 0;
            _programLogic.Teachers[3] = 0;
            _programLogic.Teachers_9[0] = 0;
            _programLogic.Teachers_9[1] = 0;
            _programLogic.Teachers_9[2] = 0;
            _programLogic.Teachers_9[3] = 0;

            _programLogic.NumberOfRuns = 0;
            semi_step = 0;
            
        }

       
        private void btStart_MouseDown(object sender, MouseEventArgs e)
        {
            if (button1_.BackColor != Color.White && button2_.BackColor != Color.White && button3_.BackColor != Color.White && button4_.BackColor != Color.White)
                return;
            label2.Text = "Simulation";
            timer1.Interval = 500;
            timer1.Enabled = true;
            step = 1;
            timer1_Tick(sender, e);                        
        }

        private void btStart_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            label2.Text = "Press/Hold Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int _ok = 0;
            switch(semi_step)
            {
                case 0:
                    {

                        while (_ok == 0)
                        {
                            _quarterTmp = Convert.ToInt16( _rndGenerator.Next(4) );

                            if (_quarterTmp == 0 && button1_.BackColor == Color.White)
                                _ok = 1;
                            if (_quarterTmp == 1 && button2_.BackColor == Color.White)
                                _ok = 1;
                            if (_quarterTmp == 2 && button3_.BackColor == Color.White)
                                _ok = 1;
                            if (_quarterTmp == 3 && button4_.BackColor == Color.White)
                                _ok = 1;
                        }
                        Experiment(_quarterTmp, 1, cbRandomLearning.Checked);
                        break;
                    }
                case 1:
                    {
                        Experiment(_quarterTmp, 2, cbRandomLearning.Checked);
                        break;
                    }
                case 2:
                    {
                        Experiment(_quarterTmp, 3, cbRandomLearning.Checked);
                        break;
                    }
            }

            

                if (timer1.Interval > 50)
                    timer1.Interval -= 40;
                else
                    if (timer1.Interval > 30)
                        timer1.Interval -= 5;

            semi_step++;
            if (semi_step > 2)
            {
                semi_step = 0;
                _programLogic.EthaFactor = _programLogic.EthaFactor * 0.99;
                step++;
            }
        }

        private void button1__Click(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.White)
                (sender as Button).BackColor = Color.Gray;
            else
                (sender as Button).BackColor = Color.White;
        }


        
    }
}

