using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Data_for_neural_networks;

namespace ModifyBitmap
{
    public partial class WindowModifyBitmap : Form
    {
        readonly int MAX_IMAGE_DIMENSION = 50;

        Bitmap BWBitmapDestination = null;
        Bitmap BWBitmapSource = null;
        Bitmap sourceOrginal = null;

        int ColorsCount = 1;
        ColorRecognizeTools colorRecognizeTools = new ColorRecognizeTools();
        int transformOption = 0;
        bool collectDebugInformations = false;

        List<Color> colors = new List<Color>();

        public WindowModifyBitmap()
        {
            InitializeComponent();
            sourceOrginal = (Bitmap)pbOrginal.Image;
        }

        private void BOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    int maxDim = (int)nudMaxDim.Value;
                    sourceOrginal = new Bitmap(ofdOpenFile.FileName);
                    Bitmap bitmap = ScaleBitmap(sourceOrginal, maxDim);
                    pbOrginal.Image = bitmap;
                    // pbOrginal.Image = bitmap;
                    pbOrginal.Refresh();
                    TransformPicture();
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show(this, "Wgrywany plik nie może być przetworzony przez program jako bitmapa!", "Błąd formatu pliku",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private Bitmap ScaleBitmap(Bitmap source, int maxDimesion)
        {
            int newWith = 0;
            int newHeight = 0;

            double ratio = source.Width / (double)source.Height;

            if (ratio >= 1)
            {
                newWith = maxDimesion;
                newHeight = (int)(maxDimesion * (source.Height / (double)source.Width));
            }
            else
            {
                newHeight = maxDimesion;
                newWith = (int)(maxDimesion * ratio);
            }

            return new Bitmap(FixedSize((Image)source, newWith, newHeight)); 
        }

        private void TransformPicture()
        {
            collectDebugInformations = cbCollectDebugInformations.Checked;
            BWBitmapSource = (Bitmap)pbOrginal.Image;

            Size s = BWBitmapSource.Size;

            try
            {
                pTop.Enabled = false;
                Bitmap scrBitmap = BWBitmapSource;
                tbInfo.Text = "0%";
                ColorsCount = (int)nudColorsCount.Value;

                transformOption = rbGrey.Checked ? 0 : 1;
                bwChangeColor.RunWorkerAsync(BWBitmapSource);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error on image transforming", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private int AvgChanging(int avg, int colorCount)
        {
            int constans = 255 / colorCount;
            int div = avg / constans;
            // adding constans makes pictures more bright, but first color should be black (0)!
            int result = div * constans;

            if (result > 255)
            {
                int p = 2;
            }

            return result;
        }

        private Color RecognizePixelByNN(Color sourceColor)
        {
            if (!colorRecognizeTools.IsNetworkLoaded())
            {
                MessageBox.Show(this, "Error during network loading... Window will not work.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return Color.Black;
            }
            else
            {
                return colorRecognizeTools.RecognizeColorByNN(sourceColor, ref collectDebugInformations);
            }
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            ResizeWindow();
        }

        private void ResizeWindow()
        {
            pLeft.Width = this.Width / 2 - 10;
            pRight.Width = this.Width / 2 - 10;

            if (pLeft.Width > pbOrginal.Width)
            {
                //pbOrginal.SizeMode = PictureBoxSizeMode.CenterImage;
            } 
            else
            {
                //pbOrginal.SizeMode = PictureBoxSizeMode.Zoom;
            }

            pbChanged.SizeMode = pbOrginal.SizeMode;
        }

        private void BModify_Click(object sender, EventArgs e)
        {
            TransformPicture();
        }

        private void bwChangeColor_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap bitmapSource = (Bitmap)((Bitmap)e.Argument).Clone();
            //You can change your new color here. Red,Green,LawnGreen any..
            Color newColor = Color.Red;
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap

            BWBitmapDestination = new Bitmap(bitmapSource.Width, bitmapSource.Height);
            int cnt = 0;
            int lastPercent = 0;
            long max = bitmapSource.Width * bitmapSource.Height;
            colors = new List<Color>();
            Console.WriteLine("Pixels to proceed: " + max);

            for (int x = 0; x < bitmapSource.Width; x++)
            {
                for (int y = 0; y < bitmapSource.Height; y++)
                {
                    int percent = (int)(cnt++ * 100 / max);

                    if (percent != lastPercent)
                    {
                        bwChangeColor.ReportProgress(percent, new long[] { cnt, max });
                    }

                    lastPercent = percent;

                    //get the pixel from the scrBitmap image
                    actualColor = bitmapSource.GetPixel(x, y);

                    switch (transformOption)
                    {
                        case 0:
                            int avg = (actualColor.R + actualColor.G + actualColor.B) / 3;
                            int val = AvgChanging(avg, ColorsCount);
                            newColor = Color.FromArgb(val, val, val);

                            break;

                        default:
                            newColor = RecognizePixelByNN(actualColor);

                            if (collectDebugInformations)
                            {
                                StreamWriter sw = new StreamWriter("Log.csv");
                                sw.WriteLine(colorRecognizeTools.Log);
                                sw.Close();
                            }

                            break;
                    }

                    if (!colors.Contains(newColor))
                    {
                        colors.Add(newColor);
                    }

                    BWBitmapDestination.SetPixel(x, y, newColor);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Colors used:");

            foreach (Color color in colors)
            {
                Console.WriteLine(color);
            }
        }

        private void BwChangeColor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            long[] tab = (long[]) e.UserState;
            tbInfo.Text = e.ProgressPercentage + "% ("+tab[0]+" / " + tab[1] + ")";
        }

        private void BwChangeColor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbChanged.Image = BWBitmapDestination;

            tbInfo.Text = colors.Count > 0 ? "Used " + colors.Count + " colors" : "";

            Console.WriteLine(colorRecognizeTools.Log);

            pTop.Enabled = true;
        }

        private void nudColorsCount_ValueChanged(object sender, EventArgs e)
        {
            if (rbGrey.Checked)
            {
                TransformPicture();
            }
        }

        private void BColorRecognizion_Click(object sender, EventArgs e)
        {
            ColorRecognize colorRecognize = new ColorRecognize();
            colorRecognize.ShowDialog();
        }

        static Image FixedSize(Image imgPhoto, int newWidth, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(newWidth, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Red);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private void Window_Load(object sender, EventArgs e)
        {
            //AllocConsole();
            RescaleImage();
            this.Show();
        }

        private void RescaleImage()
        {
            int maxDim = (int)nudMaxDim.Value;
            Bitmap bitmap = new Bitmap(pbOrginal.Image);
            if (bitmap.Width != maxDim && bitmap.Height != maxDim) {
                bitmap = ScaleBitmap(sourceOrginal, maxDim);
                pbOrginal.Image = bitmap;
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void nudMaxDim_ValueChanged(object sender, EventArgs e)
        {
            //TransformPicture();
            RescaleImage();
        }

        private void cbCollectDebugInformations_CheckedChanged(object sender, EventArgs e)
        {
            collectDebugInformations = cbCollectDebugInformations.Checked;
        }

        private void BDataForNeuralNetowrks_Click(object sender, EventArgs e)
        {
            Data_for_neural_networks.WindowDataForNeuralNetworks window = new Data_for_neural_networks.WindowDataForNeuralNetworks();
            window.Show();
        }
    }
}