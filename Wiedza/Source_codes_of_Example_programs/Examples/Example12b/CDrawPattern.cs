//----------------------------------------------------------------------------------//
//                                                                                  //
//  File name:                  CDrawPattern.cs                                     //
//                                                                                  //
//  Programming environment:    Microsoft Visual C# 2005 Express Edition            //
//                                                                                  //
//  Language:                   C#                                                  //
//                                                                                  //
//----------------------------------------------------------------------------------//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace DrawPattern
{
    //--------------------------------------------------------------------------//
    //                                                                          //
    //                          CDrawPattern()                                  //
    //                                                                          //
    //--------------------------------------------------------------------------//
    class CDrawPattern
    {
        private Graphics g;
        public Pen pen1;

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      activateFunction()                                  //
        //                                                                          //
        //              Input parameters:                                           //
        //                      PictureBox picture - a place where the program      //
        //                                            will draw patterns            //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to create graphics objects                      //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void createScene(PictureBox picture)
        {
            picture.Image = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(picture.Image);
            pen1 = new Pen(Color.Black);
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      drawOnePixel()                                      //
        //                                                                          //
        //              Input parameters:                                           //
        //                      PictureBox picture - a place where a pixel          //
        //                                             will be drawn                //
        //                      Pen penX - a pen which will do this drawing         //
        //                      Color c1 - color of the pixel                       //
        //                      Color c2 - color of this pixel border               //
        //                      Point s - a starting point                          //
        //                      Point e - the ending point                          //
        //                      bool fPixelBorder - yes or no - draw border         //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to draw one pixel                               //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void drawOnePixel(PictureBox picture, Pen penX, Color c1, Color c2,  Point s, Point e, bool fPixelBorder)
        {
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;

            penX.Color = c1;
          
            for (int i = 0; i < Math.Abs(s.Y - e.Y); i++)
            {
                 p1.X = s.X; p1.Y = s.Y + i;
                 p2.X = e.X; p2.Y = s.Y + i;
                 
                 g.DrawLine(penX, p1, p2);
            }            
                                              
            //draw border////////////                       
            if (fPixelBorder == true)
            {
                penX.Color = c2;

                p1.X = s.X; p1.Y = s.Y;
                p2.X = e.X; p2.Y = s.Y;
                g.DrawLine(penX, p1, p2);

                p1.X = s.X; p1.Y = s.Y;
                p2.X = s.X; p2.Y = e.Y;
                g.DrawLine(penX, p1, p2);

                p1.X = s.X; p1.Y = e.Y;
                p2.X = e.X; p2.Y = e.Y;
                g.DrawLine(penX, p1, p2);

                p1.X = e.X; p1.Y = s.Y;
                p2.X = e.X; p2.Y = e.Y;
                g.DrawLine(penX, p1, p2);
            }
            //////////////////////////                    
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                     drawPattern()                                        //
        //                                                                          //
        //              Input parameters:                                           //
        //                      PictureBox picture - place where this program       //
        //                                             will draw a pattern          //
        //                      int[,] Pattern - pattern array                      //
        //                      int Pattern_row - number of rows in a pattern, x    //
        //                      int Pattern_column - num.of columns in a pattern, y //
        //                      int size_pixel - size of one one pixel              //
        //                      Point start - starting point                        //
        //                      Color cPatternBorder - color of this pattern border //
        //                      Color cPixelBorder - color of pixels border         //
        //                      bool fPixelBorder - yes or no - draw pixel border   //   
        //                      bool fPatternBorder -yes or no -draw pattern border //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to draw one pattern                             //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void drawPattern(PictureBox picture, int[,] Pattern, int Pattern_row, int Pattern_column, int size_pixel, Point start, 
        Color cPatternBorder, Color cPixelBorder, bool fPatternBorder, bool fPixelBorder)
        {
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;

            pen1.Width = 1;

            for (int i = 0; i < Pattern_row; i++)
            {
                for (int j = 0; j < Pattern_column; j++)
                {
                    p1.X =  i      * size_pixel + start.X; p1.Y =  j      * size_pixel + start.Y;
                    p2.X = (i + 1) * size_pixel + start.X; p2.Y = (j + 1) * size_pixel + start.Y;

                    if (Pattern[i, j] == 0)
                    {
                        drawOnePixel(picture, pen1, Color.White, cPixelBorder, p1, p2, fPixelBorder);
                    }
                    else
                    {
                        drawOnePixel(picture, pen1, Color.Blue, cPixelBorder, p1, p2, fPixelBorder);
                    }
                }
            }

            //draw border////////////            
            if (fPatternBorder == true)
            {
                pen1.Color = cPatternBorder;

                pen1.Width = 2;

                p1.X = start.X;
                p1.Y = start.Y;

                p2.X = start.X + Pattern_row * size_pixel;
                p2.Y = start.Y;
                g.DrawLine(pen1, p1, p2);

                p1.X = start.X;
                p1.Y = start.Y;
                p2.X = start.X;
                p2.Y = start.Y + Pattern_column * size_pixel;
                g.DrawLine(pen1, p1, p2);

                p1.X = start.X;
                p1.Y = start.Y + Pattern_column * size_pixel;
                p2.X = start.X + Pattern_row * size_pixel;
                p2.Y = start.Y + Pattern_column * size_pixel;
                g.DrawLine(pen1, p1, p2);

                p1.X = start.X + Pattern_row * size_pixel;
                p1.Y = start.Y;
                p2.X = start.X + Pattern_row * size_pixel;
                p2.Y = start.Y + Pattern_column * size_pixel;
                g.DrawLine(pen1, p1, p2);
            }
            //////////////////////////
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                     drawPattern()                                        //
        //                                                                          //
        //              Input parameters:                                           //
        //                      PictureBox picture - place where this program       //
        //                                            will draw a similarity values //
        //                      Point drawPoint - a starting point                  //
        //                      String drawString - text which contains             //
        //                                             a similarity values          //                            
        //                      Color col - corol ot the text                       //
        //                      int flag  - 0 > "" / 1 -> "H" / 2 -> "DP"           //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to draw one pattern                             //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void drawNumber(PictureBox picture, Point drawPoint, String drawString, Color col, int flag)
        {                        
            // Create font and brush.
            Font drawFont = new Font("Courier New", 8);
            SolidBrush drawBrush = new SolidBrush(col);
           
            // Draw string to screen. 
            if (flag == 0)
            {
                drawPoint.X += 2;
                g.DrawString(drawString, drawFont, drawBrush, drawPoint);
            }

            if (flag == 1)
            {
                drawPoint.X -= 4;
                g.DrawString("DP " + drawString, drawFont, drawBrush, drawPoint);
            }

            if (flag == 2)
            {
                drawPoint.X -= 2;
                g.DrawString("H " + drawString, drawFont, drawBrush, drawPoint);
            }
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                     clear()                                              //
        //                                                                          //
        //              Input parameters:                                           //
        //                      PictureBox picture  - place where will be drawn     //
        //                                              a white pixel - clean       //
        //                      Point drawPoint - a starting point                  //
        //                      int pixel_size - size of a one pixel                //
        //                      int number_pixel - number of pixels                 //
        //                                            that will drawn               //
        //                      int delta - translation                             //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to clear some place in a picture                //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void clear(PictureBox picture, Point drawPoint, int pixel_size, int number_pixel, int delta)
        {
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;

            for (int i = 0; i < number_pixel; i++)
            {
                p1.X = (drawPoint.X - 4) + i * pixel_size;
                p1.Y = drawPoint.Y + delta;
                p2.X = (drawPoint.X - 4) + (i+1)* (pixel_size);
                p2.Y = drawPoint.Y + pixel_size + delta;
                
                drawOnePixel(picture, pen1, Color.White, Color.White, p1, p2, false);
            }           
        }
    }
}