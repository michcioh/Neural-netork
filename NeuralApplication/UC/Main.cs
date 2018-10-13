using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Neural
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            Main_Resize(null, null);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Size orginalPictureSize = new Size(1200, 675);
            double proportionXY = orginalPictureSize.Width / (double) orginalPictureSize.Height;
            double proportionYX = orginalPictureSize.Height / (double)orginalPictureSize.Width;

            Size panelSize = pPicture.Size;

            if (orginalPictureSize.Width < panelSize.Width && orginalPictureSize.Height < panelSize.Height)
            {
                // picture is smaller then panel

                pbNeuronsPicture.Size = orginalPictureSize;
                pbNeuronsPicture.Location = new Point((panelSize.Width - pbNeuronsPicture.Width) / 2,
                                                      (panelSize.Height - pbNeuronsPicture.Height) / 2);
            }
            else
            {
                if (orginalPictureSize.Width > panelSize.Width)
                {
                    pbNeuronsPicture.Width = panelSize.Width;
                    pbNeuronsPicture.Height = (int)(pbNeuronsPicture.Width * proportionYX);

                    pbNeuronsPicture.Location = new Point(0, (panelSize.Height - pbNeuronsPicture.Height) / 2);
                }

                if (orginalPictureSize.Height > panelSize.Height)
                {
                    pbNeuronsPicture.Height = panelSize.Height;
                    pbNeuronsPicture.Width = (int)(pbNeuronsPicture.Height * proportionXY);

                    pbNeuronsPicture.Location = new Point((panelSize.Width - pbNeuronsPicture.Width) / 2, 0);
                }
            }
        }
    }
}
