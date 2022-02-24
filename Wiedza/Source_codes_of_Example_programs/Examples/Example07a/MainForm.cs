using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;

namespace Example07
{
    public partial class MainForm : Form
    {
        private double myBias = -3.5;
        private double biasFactor = 7.0;

        private int current = 0;
        private double[] biases = new double[5];
        private Color[] colors = new Color[5];
        private bool[] blnDraw = new bool[5];

        public MainForm()
        {
            InitializeComponent();            
            colors[0] = Color.Green;
            colors[1] = Color.Red;
            colors[2] = Color.Blue;
            colors[3] = Color.Aqua;
            colors[4] = Color.IndianRed;
            colorField1.setColor(colors[0]);
            colorField2.setColor(colors[1]);
            colorField3.setColor(colors[2]);
            colorField4.setColor(colors[3]);
            colorField5.setColor(colors[4]);            

            biases[0] = myBias;
            biases[0] = biases[0] + (hScrollBar1.Value / 100.0) * biasFactor;
            textBox1.Text = biases[0].ToString("f");
            blnDraw[0] = checkBox1.Checked;

            biases[1] = myBias;
            biases[1] = biases[1] + (hScrollBar2.Value / 100.0) * biasFactor;
            textBox2.Text = biases[1].ToString("f");
            blnDraw[1] = checkBox2.Checked;

            biases[2] = myBias;
            biases[2] = biases[2] + (hScrollBar3.Value / 100.0) * biasFactor;
            textBox3.Text = biases[2].ToString("f");
            blnDraw[2] = checkBox3.Checked;

            biases[3] = myBias;
            biases[3] = biases[3] + (hScrollBar4.Value / 100.0) * biasFactor;
            textBox4.Text = biases[3].ToString("f");
            blnDraw[3] = checkBox4.Checked;

            biases[4] = myBias;
            biases[4] = biases[4] + (hScrollBar5.Value / 100.0) * biasFactor;
            textBox5.Text = biases[4].ToString("f");
            blnDraw[4] = checkBox5.Checked;

            coordinateSystem1.createBufferedImage(coordinateSystem1.Size.Width, coordinateSystem1.Size.Height);
            drawFunctions();
        }

        private void drawFunctions() 
        {
            coordinateSystem1.drawCoordinates();
            for (int i=0; i<5; i++)
            if (i!=current && blnDraw[i]) coordinateSystem1.drawActivationFunction(biases[i], colors[i]);
            if (blnDraw[current]) coordinateSystem1.drawActivationFunction(biases[current], colors[current]);
            coordinateSystem1.Refresh();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {            
            biases[0] = myBias;
            biases[0] = biases[0] + (hScrollBar1.Value / 100.0) * biasFactor;
            textBox1.Text = biases[0].ToString("f"); 
            if (checkBox1.Checked)
            {
                current = 0;
                drawFunctions();
                blnDraw[0] = true;
            }
            else blnDraw[0] = false;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {            
            biases[1] = myBias;
            biases[1] = biases[1] + (hScrollBar2.Value / 100.0) * biasFactor;
            textBox2.Text = biases[1].ToString("f");     
            if (checkBox2.Checked)
            {
                current = 1;
                drawFunctions();
                blnDraw[1] = true;
            }
            else blnDraw[1] = false;
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {            
            biases[2] = myBias;
            biases[2] = biases[2] + (hScrollBar3.Value / 100.0) * biasFactor;
            textBox3.Text = biases[2].ToString("f");
            if (checkBox3.Checked)
            {
                current = 2;
                drawFunctions();
                blnDraw[2] = true;
            }
            else blnDraw[2] = false;
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {            
            biases[3] = myBias;
            biases[3] = biases[3] + (hScrollBar4.Value / 100.0) * biasFactor;
            textBox4.Text = biases[3].ToString("f");            
            if (checkBox4.Checked)
            {
                current = 3;
                drawFunctions();
                blnDraw[3] = true;
            }
            else blnDraw[3] = false;
        }

        private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
        {
            biases[4] = myBias;
            biases[4] = biases[4] + (hScrollBar5.Value / 100.0) * biasFactor;
            textBox5.Text = biases[4].ToString("f");            
            if (checkBox5.Checked)
            {
                current = 4;
                drawFunctions();
                blnDraw[4] = true;
            }
            else blnDraw[4] = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                blnDraw[0] = true;
                current = 0;
            }
            else blnDraw[0] = false;
            drawFunctions();            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                blnDraw[1] = true;
                current = 1;
            }
            else blnDraw[1] = false;
            drawFunctions();     
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                blnDraw[2] = true;
                current = 2;
            }
            else blnDraw[2] = false;
            drawFunctions();     
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                blnDraw[3] = true;
                current = 3;
            }
            else blnDraw[3] = false;
            drawFunctions();     
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                blnDraw[4] = true;
                current = 4;
            }
            else blnDraw[4] = false;
            drawFunctions();     
        }
    }
}