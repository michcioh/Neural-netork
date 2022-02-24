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


namespace RTadeusiewicz.NN.Example10c
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
        private int step = 0;
     //   private int semi_step = 0;
        private int _quarterTmp;

        private int d = 8;


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
            _programLogic.Quarter_winner[0] = -1;
            _programLogic.Quarter_winner[1] = -1;
            _programLogic.Quarter_winner[2] = -1;
            _programLogic.Quarter_winner[3] = -1;
           // semi_step = 0;

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
                         if (step > 0)
                             if(_programLogic.ExaminedNetwork.Neurons_dist[_programLogic.Winner] > 0.08)
                                   drawTeacher(false,empty);
                              else
                             drawTeacher(false, Color.Red);



                         if (_rnd)
                         {
                             x = Convert.ToInt32(18 * _rndGenerator.NextDouble() - 9);
                             y = Convert.ToInt32(18 * _rndGenerator.NextDouble() - 9);
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

                         _programLogic.TeachingElement.Inputs[0] = x;
                         _programLogic.TeachingElement.Inputs[1] = y;

                         drawText();
                         drawCoordinate();
                         drawTeacher(true,empty);
                         imgBitmap.Refresh();
                         break;
                     }
                 case 2:
                     {
                         _programLogic.PerformExperiment(_programLogic.TeachingElement.Inputs);
                         if (_programLogic.Soft == true && 
                             _programLogic.ExaminedNetwork.Neurons_dist[_programLogic.Winner] > 7.5)
                         {
                             // Brak zwyciezcy
                             _programLogic.Quarter_winner[_quarter] = -1;
                             
                         }
                         else
                         {
                             _programLogic.PerformTeaching(_programLogic.TeachingElement.Inputs);
                             _programLogic.PerformExperiment(_programLogic.TeachingElement.Inputs);
                             _programLogic.Quarter_winner[_quarter] = _programLogic.Winner;
                         }

                         if (!(_programLogic.ExaminedNetwork.Neurons_dist[_programLogic.Winner] > 0.08))
                      //      drawTeacher(false,empty);
                        // else
                            drawTeacher(false, Color.Red);

                        
                         drawResponse();
                         drawText();
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


        public void drawText()
        {
            Font fn = new Font("System", 8, FontStyle.Bold);
            String s;

            g.FillRectangle(new SolidBrush(empty), imgBitmap.Width - 80, 2, 70, 20);

            {
                // I
                if (_programLogic.Quarter_winner[0] == -1) s = "no winner";
                else s = "winner: " + _programLogic.Quarter_winner[0].ToString();

                
                g.DrawString(s, fn, new SolidBrush(Color.Black), imgBitmap.Width - 80, 2);

                // II
                g.FillRectangle(new SolidBrush(empty), 2, 2, 100, 20);

                if (_programLogic.Quarter_winner[1] == -1) s = "no winner";
                else s = "winner: " + _programLogic.Quarter_winner[1].ToString();
                
                g.DrawString(s, fn, new SolidBrush(Color.Black), 2, 2);

                // III
                g.FillRectangle(new SolidBrush(empty), 2, imgBitmap.Height - 20, 100, 20);
                if (_programLogic.Quarter_winner[2] == -1) s = "no winner";
                else s = "winner: " + _programLogic.Quarter_winner[2].ToString();
                g.DrawString(s, fn, new SolidBrush(Color.Black), 2, imgBitmap.Height - 20);


                // IV
                g.FillRectangle(new SolidBrush(empty), imgBitmap.Width - 80, imgBitmap.Height - 20, 70, 20);
                if (_programLogic.Quarter_winner[3] == -1) s = "no winner"; 
                else s = "winner: " + _programLogic.Quarter_winner[3].ToString();
                
                g.DrawString(s, fn, new SolidBrush(Color.Black), imgBitmap.Width - 80, imgBitmap.Height - 20);
            }

        }

        //Rysowanie wag neuronow oraz odpowiedzi neuronow(kolory)
        public void drawResponse()
        {
            int x, y;
            double max = 0;
            double response;
            double _max = 0;
            int _num = -1;


            if (_programLogic.Soft == true &&
                   _programLogic.ExaminedNetwork.Neurons_dist[_programLogic.Winner] > 7.5)
                return;
            //rysowanie pobudzenia neuronow, w zaleznosci o wartosci, sa rozne kolory


            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                response = _programLogic.CurrentResponse[i];
                if (Math.Abs(response) > max)
                    max = response;
                if (response > _max && response < 48)
                {
                    _max = response;
                    _num = i;
                }
            }

            _programLogic.Ranges[0] = 0;
            _programLogic.Ranges[1] = 0;
            _programLogic.Ranges[2] = 0;
            _programLogic.Ranges[3] = 0;

            if (_num > -1)
            {
                for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
                {
                    x = Conv(_programLogic.ExaminedNetwork.Neurons[i].Weights[0]);
                    y = Conv(_programLogic.ExaminedNetwork.Neurons[i].Weights[1]);

                    if (x >= 0 && y >= 0) _programLogic.Ranges[0]++;
                    if (x < 0 && y >= 0) _programLogic.Ranges[1]++;
                    if (x < 0 && y < 0) _programLogic.Ranges[2]++;
                    if (x >= 0 && y < 0) _programLogic.Ranges[3]++;
                }
            }
            for (int i = 0; i < _programLogic.NumberOfNeurons; i++)
            {
                response = _programLogic.CurrentResponse[i];
                pen.Color = Color.Black;

                if (i == _num)
                {
                    pen.Color = Color.Red;

                    x = FixX(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].Weights[0]));
                    y = FixY(FixDouble(_programLogic.ExaminedNetwork.Neurons[i].Weights[1]));

                    _draw(x, y, pen, 4);
                }
            }
            pen.Color = Color.Black;
            
            drawText();
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
                _draw(x, y, pen,4);

            }
        }

        //Rysowanie obiktu uczacego
        public void drawTeacher(bool erase,Color col)
        {
            int x, y;
            if (erase)
                pen.Color = Color.Green;
            else
                pen.Color = col;

            x = FixX(FixDouble(_programLogic.TeachingElement.Inputs[0]));
            y = FixY(FixDouble(_programLogic.TeachingElement.Inputs[1]));

            if (erase)
            _draw(x-2, y-2, pen,8);
            else
            _draw(x-3, y-3, pen,9);
        }

        // Rysowanie
        public void _draw(int x, int y,Pen _pen,int _size)
        {
            if ((x > -1) && (x < imgBitmap.Width + 1) && (y > -1) && (y < imgBitmap.Height + 1))
            {
                if (_pen.Color==Color.DarkViolet)
                    g.FillRectangle(new SolidBrush(_pen.Color), x - 3, y - 3, _size, _size);
                else
                    g.FillRectangle(new SolidBrush(_pen.Color), x - 2, y - 2, _size, _size);
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
            label2.Text = "Choose a quarter";
            _programLogic.Quarter_winner[0] = -1;
            _programLogic.Quarter_winner[1] = -1;
            _programLogic.Quarter_winner[2] = -1;
            _programLogic.Quarter_winner[3] = -1;
            step = 0;
           // semi_step = 0;
            
        }

        // Detekcja klikniêcia
        private void imgBitmap_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
                  
        }

        private void btStart_MouseDown(object sender, MouseEventArgs e)
        {
            if (button1_.BackColor != Color.White && button2_.BackColor != Color.White && button3_.BackColor != Color.White && button4_.BackColor != Color.White)
                return;
            label2.Text = "Simulation";
            timer1.Interval = 500;
            timer1.Enabled = true;
        //    step = 1;
            timer1_Tick(sender, e);                        
        }

        private void btStart_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            label2.Text = "Press/Hold Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            int _ok=0;
           // switch(semi_step)
           // {
               // case 0:
                   // {                        
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
                        Experiment(_quarterTmp, 2, cbRandomLearning.Checked);
                       // break;
                   // }
              //  case 1:
                  //  {
                   //     Experiment(_quarterTmp, 2, cbRandomLearning.Checked);
//break;
                    //}
               // case 2:
                   // {
                     //   Experiment(_quarterTmp, 3, cbRandomLearning.Checked);
                     //   break;
                   // }
           // }

                if (timer1.Interval > 50)
                    timer1.Interval -= 40;
                else
                    if (timer1.Interval > 30)
                        timer1.Interval -= 5;

           // semi_step++;
           // if (semi_step > 1)
           // {
              // semi_step = 0;
                step++;
            //}
        }

        private void button1__Click(object sender, EventArgs e)
        {
             if ((sender as Button).BackColor == Color.White)
                (sender as Button).BackColor = Color.Gray;
            else
                (sender as Button).BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d -= 2;
            if (d < -10)
                d = 10;
        }  




        
    }
}

