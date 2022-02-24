using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Example07
{
    public partial class ColorField : UserControl
    {
        private Color myColor = new Color();

        public ColorField()
        {
            InitializeComponent();
        }

        private void ColorField_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(myColor);
        }

        public void setColor(Color col)
        {
            myColor = col;
        }
    }
}
