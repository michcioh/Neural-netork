using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example09
{
    public partial class Simulation : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;
        private Color empty = Color.White;
        private Pen pen;
        private Graphics g;
        private int _quarter;
        private Rectangle rect = new Rectangle();
        private int box_in_line = 8;
        private Color empty_gen = Color.WhiteSmoke;
        private bool simulation_started = false;
 
        

        internal Simulation(ProgramLogic programLogic)
        {
            InitializeComponent();
            _programLogic = programLogic;

            imgBitmap.Image = new Bitmap(imgBitmap.Width, imgBitmap.Height);
            g = Graphics.FromImage(imgBitmap.Image);
            pen = new Pen(Color.Black);
            g.Clear(empty);

            rect.Width = 60;
            rect.Height = 60;
      
           
            _quarter = 0;

            SetsDistribution();
            _quarter++;

            g.FillRectangle(new SolidBrush(empty_gen), 10,
                  80, 4 * 30 + 12, 4 * 30 + 12);




        }

        private void SetsDistribution()
        {

            Pen p = new Pen(Color.Black);
            
            for (int i = 0; i <= 30; i++)
                for (int j = 0; j <= 30; j++)
                {
                    _programLogic.y[0,0] = ((1.0 * (i - 15)) / 15.0) * _programLogic.Scale;
                    _programLogic.y[0,1] = ((1.0 * (j - 15)) / 15.0) * _programLogic.Scale;

                    _programLogic.WhichSet();

                    p.Color = _programLogic.colors[ Convert.ToInt16(_programLogic.d[0]) ];


                    g.DrawEllipse(p, FixX(i * 2, _quarter),
                       FixY(j * 2, _quarter), 2, 1);
                }
        }

        public void IncQuarter()
        {
            if (_quarter == 7 || _quarter == 15 )
                _quarter = _quarter + 2;

            _quarter++;

            if (_quarter > 23)
                _quarter = 1;

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

        public int FixX(double x, int quarter)
        {
            int q = quarter;

            if (q>7 && q<=15)
                q -= 8;

            if (q>15)
                q -= 16;

            int _x = 70 * q;

            _x = 10 + Convert.ToInt16(x) + _x;
            return _x;           
        }

        public int FixY(double y, int quarter)
        {
            int _y = 10+Convert.ToInt16( y)+ (quarter / box_in_line) * 70;
            return _y;
        }


        private void draw_view(int quarter, Color col, int clear)
        {
            rect.X = FixX(0, quarter);
            rect.Y = FixY(0, quarter);
            if (clear == 1)
                g.FillRectangle(new SolidBrush(empty), rect.X,
                    rect.Y , rect.Width+1, rect.Height+1);
            g.DrawRectangle(new Pen(col), rect.X,
                    rect.Y, rect.Width + 2, rect.Height + 2);

            imgBitmap.Refresh();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            _programLogic.Eta =  Convert.ToDouble( nrEta.Value );
            _programLogic.Alpha = Convert.ToDouble( nrAlpha.Value );

            int Iterations = Convert.ToInt16( nrIteractions.Value );

            // dodalem
            g.FillRectangle(new SolidBrush(empty), 10 - 3,
                  80 - 3, 4 * 30 + 19, 4 * 30 + 19);
            g.FillRectangle(new SolidBrush(empty_gen), 10,
                   80, 4 * 30 + 12, 4 * 30 + 12);


            if (_quarter != 10 && _quarter != 18)
                draw_view(_quarter - 1, empty, 0);

            if (_quarter != 11 && _quarter != 12 && _quarter != 19 && _quarter != 20)
                draw_view(_quarter - 3, empty, 0);

            if (_quarter == 1 )
                draw_view(23, empty, 0);

            if ( simulation_started ) //to avoid calculations for first quarter when not learned network response is shown
            {
                _programLogic.TotalIterations += Iterations;

                while (Iterations > 0)
                {
                    _programLogic.y[0, 0] = (_programLogic._rndGenerator.NextDouble() * 2 - 1) *
                        _programLogic.Scale;
                    _programLogic.y[0, 1] = (_programLogic._rndGenerator.NextDouble() * 2 - 1) *
                        _programLogic.Scale;

                    _programLogic.WhichSet();
                    ShowPoint();
                    _programLogic.NetworkRespond();
                    _programLogic.WeightAdaptation();
                    Iterations--;
                }
            }
            
            ReconnaiseSet();
            draw_view(_quarter, Color.FromArgb(255, 77, 0), 0);
            IncQuarter();
            uiTotalIterations.Text = _programLogic.TotalIterations.ToString();
            simulation_started = true;
          
        }

        private void ShowPoint()
        {
            Color c;
            Pen p = new Pen(Color.Black);

            double i = (_programLogic.y[0, 0] / _programLogic.Scale * 15.0) + 15;
            double j = (_programLogic.y[0, 1] / _programLogic.Scale * 15.0) + 15;

            c = _programLogic.colors[_programLogic.d[0]];
            p.Color = c;
            g.DrawEllipse(p, 10+ Convert.ToInt16(4.3*i)-1,
                80 + Convert.ToInt16(4.3 * j )-1, 3, 3);

        }

        private void ReconnaiseSet()
        {
            Color c=Color.Pink;
            Pen p = new Pen(Color.Black);
            double res;

            for (int i = 0 ; i <= 30 ; i++ )
                for (int j = 0; j <= 30; j++)
                {
                    _programLogic.y[0, 0] = ((1.0*(i - 15)) / 15.0) * _programLogic.Scale;
                    _programLogic.y[0, 1] = ((1.0*(j - 15)) / 15.0) * _programLogic.Scale;

                    _programLogic.NetworkRespond();

                    res = _programLogic.y[_programLogic.Layers, 0];

                    //if (res <= 0.3)
                    //    c = Color.LightSkyBlue;
                    //if (res > 0.3 && res <= 0.4)
                    //    c = Color.YellowGreen;
                    //if (res > 0.4 && res <= 0.5)
                    //    c = Color.LightGreen;
                    //if (res > 0.5 && res <= 0.6)
                    //    c = Color.Yellow;
                    //if (res > 0.6 && res <= 0.7)
                    //    c = Color.Goldenrod;
                    //if (res > 0.7)
                    //    c = Color.Red;


                    if (res <= 0.3)
                        c = Color.FromArgb(0, 166, 255);
                    if (res > 0.3 && res <= 0.35)
                        c = Color.FromArgb(0, 198, 255); ;
                    if (res > 0.35 && res <= 0.4)
                        c = Color.FromArgb(0, 255, 236);
                    if (res > 0.4 && res <= 0.45)
                        c = Color.FromArgb(0, 255, 147);
                    if (res > 0.45 && res <= 0.5)
                        c = Color.FromArgb(13, 255, 0);
                    if (res > 0.5 && res <= 0.55)
                        c = Color.FromArgb(130, 255, 0);
                    if (res > 0.55 && res <= 0.6)
                        c = Color.FromArgb(190, 255, 0);
                    if (res > 0.6 && res <= 0.65)
                        c = Color.FromArgb(255, 255, 0);
                    if (res > 0.65 && res <= 0.7)
                        c = Color.FromArgb(255, 172, 0);
                    if (res > 0.7)
                        c = Color.FromArgb(255, 77, 0);
                    
 

                    p.Color = c;
                    g.DrawEllipse(p,FixX(i * 2,_quarter),
                        FixY(j * 2,_quarter),2,1);
                }
        }




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }

        private void nrIteractions_ValueChanged(object sender, EventArgs e)
        {

        }

        private void imgBitmap_Click(object sender, EventArgs e)
        {

        }

     
    }
}

  