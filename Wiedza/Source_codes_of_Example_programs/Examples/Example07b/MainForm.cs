using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example07
{
    public partial class MainForm : Form
    {
        private double myBeta = 0.0;
        private double betaFactor = 20.0;

        private int current = 0;
        private double[] betas = new double[5];
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

            betas[0] = myBeta;
            betas[0] = betas[0] + (hScrollBar1.Value / 100.0) * betaFactor;
            textBox1.Text = betas[0].ToString("f");
            blnDraw[0] = checkBox1.Checked;

            betas[1] = myBeta;
            betas[1] = betas[1] + (hScrollBar2.Value / 100.0) * betaFactor;
            textBox2.Text = betas[1].ToString("f");
            blnDraw[1] = checkBox2.Checked;

            betas[2] = myBeta;
            betas[2] = betas[2] + (hScrollBar3.Value / 100.0) * betaFactor;
            textBox3.Text = betas[2].ToString("f");
            blnDraw[2] = checkBox3.Checked;

            betas[3] = myBeta;
            betas[3] = betas[3] + (hScrollBar4.Value / 100.0) * betaFactor;
            textBox4.Text = betas[3].ToString("f");
            blnDraw[3] = checkBox4.Checked;

            betas[4] = myBeta;
            betas[4] = betas[4] + (hScrollBar5.Value / 100.0) * betaFactor;
            textBox5.Text = betas[4].ToString("f");
            blnDraw[4] = checkBox5.Checked;

            coordinateSystem1.createBufferedImage(coordinateSystem1.Size.Width, coordinateSystem1.Size.Height);
            drawFunctions();
        }

        private void drawFunctions()
        {
            coordinateSystem1.drawCoordinates();
            for (int i = 0; i < 5; i++)
                if (i != current && blnDraw[i]) coordinateSystem1.drawLogisticCurve(betas[i], colors[i]);
            if (blnDraw[current]) coordinateSystem1.drawLogisticCurve(betas[current], colors[current]);
            coordinateSystem1.Refresh();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            betas[0] = myBeta;
            betas[0] = betas[0] + (hScrollBar1.Value / 100.0) * betaFactor;
            textBox1.Text = betas[0].ToString("f");
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
            betas[1] = myBeta;
            betas[1] = betas[1] + (hScrollBar2.Value / 100.0) * betaFactor;
            textBox2.Text = betas[1].ToString("f");
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
            betas[2] = myBeta;
            betas[2] = betas[2] + (hScrollBar3.Value / 100.0) * betaFactor;
            textBox3.Text = betas[2].ToString("f");
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
            betas[3] = myBeta;
            betas[3] = betas[3] + (hScrollBar4.Value / 100.0) * betaFactor;
            textBox4.Text = betas[3].ToString("f");
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
            betas[4] = myBeta;
            betas[4] = betas[4] + (hScrollBar5.Value / 100.0) * betaFactor;
            textBox5.Text = betas[4].ToString("f");
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