//----------------------------------------------------------------------------------//
//                                                                                  //
//  File name:                  CPatterns.cs                                        //
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

namespace Pattern
{
    //--------------------------------------------------------------------------//
    //                                                                          //
    //                          Class CPattern()                                //
    //                                                                          //
    //--------------------------------------------------------------------------//
    class CPattern
    {
        public Point start;
        public Point end;
        
        public int [,]PATTERN_XX;
        public int similarity;

        public static int FLAG_SIMILARITY; //1 - max //2 - min

        public static int[,] EMPTY = new int[,]    {{0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_A = new int[,] {{0,0,0,0,1,1,1,1,1,1,0,0},
									                {0,0,0,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,0,0,1,0,0,0,0,0},
									                {0,1,1,0,0,0,1,0,0,0,0,0},
									                {0,0,1,1,0,0,1,0,0,0,0,0},
									                {0,0,0,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_B = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,1,0,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_C = new int[,] {{0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,0,1,1,0,0,0,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_D = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_E = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,1,1,1,0,0,1,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,1,1,1,0,0,0,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_F = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,1,1,1,0,0,0,0,0},
									                {0,1,1,0,0,0,0,0,0,0,0,0},
									                {0,1,1,1,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_G = new int[,] {{0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,1,0,0,0,0,1,0,0,1,0,0},
									                {0,1,0,0,0,0,1,0,0,1,0,0},
									                {0,1,1,0,0,0,1,1,1,0,0,0},
									                {0,0,1,1,0,0,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_H = new int[,] {{0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,1,0,0,0,0,0,0},
									                {0,0,0,0,0,1,0,0,0,0,0,0},
									                {0,0,0,0,0,1,0,0,0,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_I = new int[,] {{0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_J = new int[,] {{0,0,0,0,0,0,0,1,1,0,0,0},
									                {0,0,0,0,0,0,0,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,1,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,0,0,0},
									                {0,1,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_K = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,1,0,0,0,0,0,0},
									                {0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,1,1,1,1,0,1,1,1,1,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_L = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,1,1,0,0},
									                {0,0,0,0,0,0,0,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_M = new int[,] {{0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,1,0,0,0,0,0,0,0},
									                {0,0,0,1,1,1,0,0,0,0,0,0},
									                {0,0,1,1,1,0,0,0,0,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_N = new int[,] {{0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,1,0,0,0,0,0,0,0},
									                {0,0,0,1,1,1,0,0,0,0,0,0},
									                {0,0,0,0,1,1,1,0,0,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_O = new int[,] {{0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_P = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,0,0,0},
									                {0,1,1,1,1,1,0,0,0,0,0,0},
									                {0,0,1,1,1,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_Q = new int[,] {{0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,1,0,0,0,0,1,0,0,1,0,0},
									                {0,1,1,0,0,0,0,1,1,1,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,0,0,1,1,1,1,1,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_R = new int[,] {{0,1,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,0,0,0},
									                {0,1,0,0,0,1,1,0,0,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,1,0,0,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_S = new int[,] {{0,0,1,1,0,0,0,1,1,0,0,0},
									                {0,1,1,1,1,0,0,1,1,1,0,0},
									                {0,1,0,0,1,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,1,0,0,1,0,0},
									                {0,1,1,1,0,0,1,1,1,1,0,0},
									                {0,0,1,1,0,0,0,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_T = new int[,] {{0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,1,1,1,0,0,0,0,0,0,0,0},
									                {0,1,1,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_U = new int[,] {{0,1,1,1,1,1,1,1,1,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_V = new int[,] {{0,1,1,1,0,0,0,0,0,0,0,0},
									                {0,1,1,1,1,1,1,0,0,0,0,0},
									                {0,0,0,0,1,1,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,1,1,0,0},
									                {0,0,0,0,1,1,1,1,1,0,0,0},
									                {0,1,1,1,1,1,1,0,0,0,0,0},
									                {0,1,1,1,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_W = new int[,] {{0,1,1,1,1,1,1,1,0,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,1,1,1,0,0},
									                {0,0,0,0,0,1,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_X = new int[,] {{0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,1,1,1,0,0,0,1,1,1,0,0},
									                {0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,0,0,0,1,1,1,0,0,0,0,0},
									                {0,0,0,1,1,1,1,1,0,0,0,0},
									                {0,1,1,1,0,0,0,1,1,1,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_Y = new int[,] {{0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,1,1,1,1,0,0,0,0,0,0,0},
									                {0,1,1,1,1,1,0,0,0,1,0,0},
									                {0,0,0,0,0,1,1,1,1,1,0,0},
									                {0,0,0,0,0,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,0,0,0,1,0,0},
									                {0,1,1,1,1,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_Z = new int[,] {{0,1,1,1,0,0,0,1,1,1,0,0},
									                {0,1,1,0,0,0,1,1,1,1,0,0},
									                {0,1,0,0,0,1,1,0,0,1,0,0},
									                {0,1,0,0,1,1,0,0,0,1,0,0},
									                {0,1,0,1,1,0,0,0,0,1,0,0},
									                {0,1,1,1,0,0,0,0,1,1,0,0},
									                {0,1,1,0,0,0,0,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_0 = new int[,] {{0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,1,1,0,0,1,0,0},
									                {0,1,0,0,1,1,0,0,0,1,0,0},
									                {0,1,0,1,1,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,1,1,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_1 = new int[,] {{0,0,0,0,0,0,0,0,0,0,0,0},
									                {0,0,0,1,0,0,0,0,0,1,0,0},
									                {0,0,1,1,0,0,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_2 = new int[,] {{0,0,1,0,0,0,0,0,1,1,0,0},
									                {0,1,1,0,0,0,0,1,1,1,0,0},
									                {0,1,0,0,0,0,1,1,0,1,0,0},
									                {0,1,0,0,0,1,1,0,0,1,0,0},
									                {0,1,0,0,1,1,0,0,0,1,0,0},
									                {0,1,1,1,1,0,0,0,1,1,0,0},
									                {0,0,1,1,0,0,0,0,1,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_3 = new int[,] {{0,0,1,0,0,0,0,0,1,0,0,0},
									                {0,1,1,0,0,0,0,0,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,1,0,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_4 = new int[,] {{0,0,0,0,0,1,1,0,0,0,0,0},
									                {0,0,0,0,1,1,1,0,0,0,0,0},
									                {0,0,0,1,1,0,1,0,0,0,0,0},
									                {0,0,1,1,0,0,1,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,1,0,0,1,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_5 = new int[,] {{0,1,1,1,1,1,0,0,1,0,0,0},
									                {0,1,1,1,1,1,0,0,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,1,1,1,1,0,0},
									                {0,1,0,0,0,0,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_6 = new int[,] {{0,0,0,1,1,1,1,1,1,0,0,0},
									                {0,0,1,1,1,1,1,1,1,1,0,0},
									                {0,1,1,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,0,0,0,0,1,1,1,1,1,0,0},
									                {0,0,0,0,0,0,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_7 = new int[,] {{0,1,1,0,0,0,0,0,0,0,0,0},
									                {0,1,1,0,0,0,0,0,0,0,0,0},
									                {0,1,0,0,0,0,1,1,1,1,0,0},
									                {0,1,0,0,0,1,1,1,1,1,0,0},
									                {0,1,0,0,1,1,0,0,0,0,0,0},
									                {0,1,1,1,1,0,0,0,0,0,0,0},
									                {0,1,1,1,0,0,0,0,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_8 = new int[,] {{0,0,1,1,1,0,1,1,1,0,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,1,1,1,1,1,1,1,1,0,0},
									                {0,0,1,1,1,0,1,1,1,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};

        public static int[,] LETTER_9 = new int[,] {{0,0,1,1,1,0,0,0,0,0,0,0},
									                {0,1,1,1,1,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,0,1,0,0},
									                {0,1,0,0,0,1,0,0,1,1,0,0},
									                {0,1,1,1,1,1,1,1,1,0,0,0},
									                {0,0,1,1,1,1,1,1,0,0,0,0},
									                {0,0,0,0,0,0,0,0,0,0,0,0}};


        //--------------------------------------------------------------------------//
        //                                                                          //
        //              CPattern()                                                  //
        //              [Constructor - 1]                                           //
        //                                                                          //
        //              Input parameters:                                           //
        //                      Point s - coordinates start pixel (x,y)             //
        //                      Point e - coordinates end pixel (x,y)               //
        //                      int [,] letter - pattern array                      //
        //                      int row - pattern x size                            //
        //                      int column - pattern y size                         //
        //                                                                          //
        //              Describe:                                                   //
        //                 Create new pattern object.                               //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public CPattern(Point s, Point e, int [,] letter, int row, int column)
        {            
            PATTERN_XX = new int[row, column];
            
            FLAG_SIMILARITY = 1;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    PATTERN_XX[i, j] = letter[i, j];
            
            start.X = s.X; start.Y = s.Y;
            end.X   = e.X; end.Y   = e.Y;
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              CPattern()                                                  //
        //              [Constructor - 2]                                           //
        //                                                                          //
        //              Input parameters:                                           //
        //                      Point s - coordinates start pixel (x,y)             //
        //                      Point e - coordinates end pixel (x,y)               //
        //                      char letter_number - pattern character              //
        //                      int row - pattern x size                            //
        //                      int column - pattern y size                         //
        //                                                                          //
        //              Describe:                                                   //
        //                 Create new pattern object.                               //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public CPattern(Point s, Point e, char letter_number, int row, int column)
        {            
            PATTERN_XX = new int[row, column];
            
            FLAG_SIMILARITY = 1;

            switch (letter_number)
            {
                case 'a':
                case 'A':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_A[i, j];

                    break;

                case 'b':
                case 'B':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_B[i, j];

                    break;

                case 'c':
                case 'C':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_C[i, j];

                    break;

                case 'd':
                case 'D':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_D[i, j];

                    break;

                case 'e':
                case 'E':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_E[i, j];

                    break;

                case 'f':
                case 'F':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_F[i, j];

                    break;

                case 'g':
                case 'G':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_G[i, j];

                    break;

                case 'h':
                case 'H':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_H[i, j];

                    break;

                case 'i':
                case 'I':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_I[i, j];

                    break;

                case 'j':
                case 'J':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_J[i, j];

                    break;

                case 'k':
                case 'K':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_K[i, j];

                    break;

                case 'l':
                case 'L':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_L[i, j];

                    break;

                case 'm':
                case 'M':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_M[i, j];

                    break;

                case 'n':
                case 'N':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_N[i, j];

                    break;

                case 'o':
                case 'O':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_O[i, j];

                    break;

                case 'p':
                case 'P':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_P[i, j];

                    break;

                case 'q':
                case 'Q':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_Q[i, j];

                    break;

                case 'r':
                case 'R':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_R[i, j];

                    break;

                case 's':
                case 'S':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_S[i, j];

                    break;

                case 't':
                case 'T':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_T[i, j];

                    break;

                case 'u':
                case 'U':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_U[i, j];

                    break;

                case 'v':
                case 'V':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_V[i, j];
                    
                    break;

                case 'w':
                case 'W':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_W[i, j];

                    break;

                case 'x':
                case 'X':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_X[i, j];

                    break;

                case 'y':
                case 'Y':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_Y[i, j];

                    break;

                case 'z':
                case 'Z':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_Z[i, j];

                    break;

                case '0':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_0[i, j];
                    
                    break;

                case '1':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_1[i, j];

                    break;

                case '2':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_2[i, j];

                    break;

                case '3':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_3[i, j];

                    break;

                case '4':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_4[i, j];

                    break;

                case '5':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_5[i, j];

                    break;

                case '6':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_6[i, j];

                    break;

                case '7':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_7[i, j];

                    break;

                case '8':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_8[i, j];

                    break;

                case '9':

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < column; j++)
                            PATTERN_XX[i, j] = LETTER_9[i, j];

                    break;                       
            }
       
            start.X = s.X; start.Y = s.Y;
            end.X = e.X; end.Y = e.Y;
        }
        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      calcSimilarity()                                    //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] pattern1 - pattern array 1                   //
        //                      int[,] pattern2 - pattern array 2                   //
        //                      int flag - dot product/Hamming distance             //
        //                      int row - pattern x size                            //
        //                      int column - pattern y size                         //
        //                                                                          //
        //              Return value (int):                                         //
        //                      dot product or Hamming distance                     //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to calculate a dot product or a Hamming distance//
        //                                                                          //
        //--------------------------------------------------------------------------//
        public static int calcSimilarity(int[,] pattern1, int[,] pattern2, int row, int column, int flag)
        {
            int hammingDistance = 0;
            int dotProduct = 0;

            int a,b;

            if (flag == 1)
            {
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < column; j++)
                    {
                        if(pattern1[i, j] > 0)
                            a = 1;
                        else
                            a = -1;
                        
                        if(pattern2[i, j] > 0)
                            b = 1;
                        else
                            b = -1;

                        dotProduct += a * b;
                    }

                return Math.Abs(dotProduct);
            }
            else
            {
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < column; j++)
                        if(pattern1[i,j] != pattern2[i,j]) 
                            hammingDistance += 1;
                
                return hammingDistance;
            }
                       
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      generatePatternPRandom()                            //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] pattern - output pattern array               //
        //                      int row - pattern x size                            //
        //                      int column - pattern y size                         //
        //                      Random rnd - random object                          //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function generates pseudorandom pattern                  //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public static void generatePatternPRandom(int[,] pattern, int row, int column, Random rnd)
        {            
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {                  
                    if (rnd.NextDouble() < 0.5)
                    {
                            pattern[i, j] = 0;
                    }
                    else
                    {
                        pattern[i, j] = 1;
                    }                                       
                }
        }       

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      inversePattern()                                    //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] pattern - input/output pattern array         //
        //                      int row - pattern x size                            //
        //                      int column - pattern y size                         //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function converts pattern value (0->1 and 1->0)          //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public static void inversePattern(int[,] pattern, int row, int column)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {
                    if (pattern[i, j] == 1)
                        pattern[i, j] = 0;
                    else
                        pattern[i, j] = 1;
                }
        
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      noisePattern()                                      //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] pattern - input/output pattern array         //
        //                      int row - pattern x size                            //
        //                      int column - pattern y size                         //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to generate a noise in a pattern                //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public static void noisePattern(int[,] pattern, int percent, int row, int column)
        {            
            Random rnd = new Random();

            int numberOfpixels, i, j;
            int num = 0;

            int[, ] pattNoise  = new int[row, column];

            numberOfpixels = (int) (percent * 0.96); // number of pixels that should get changed         
            
             for (i = 0; i < row; i++)
                for (j = 0; j < column; j++)
                    pattNoise[i, j] = pattern[i, j];
 
             for (i = 0; i < row; i++)
                for (j = column - 1; j >= 0; j--)
                {
                    if (rnd.NextDouble() < 0.5)
                    {
                        if (pattern[i, j] == 1)
                            pattern[i, j] = 0;
                        else
                            pattern[i, j] = 1;
                    num++;
                      if (num == numberOfpixels)
                        {
                          i = row;
                          j = 0;      //  because:  for (int j = column - 1; j ==0; j--)
                        }    // if num                   
                    }  // if rnd
                }  // for i,j

            if (num < numberOfpixels)   // more pixels need to be made with noise
             {
              while (num < numberOfpixels)
               {
             for (i = 0; i < row; i++)
                for (j = column - 1; j >= 0; j--)
                {
                    if (rnd.NextDouble() < 0.9)
                    {
                        if (pattNoise[i, j] == pattern[i, j])
                           {
                            if (pattern[i, j] == 1)  
                                pattern[i, j] = 0;
                             else
                                pattern[i, j] = 1;
                           num++;
                            }
                       if (num == numberOfpixels)
                        {
                          i = row;
                          j = -1;      //  because:  for (int j = column - 1; j ==0; j--)
                        }    // if num  
                 
                    }  // if rnd
                }  // for i,j
               }  // while num
              } // if num
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      findMaxSimilar()                                    //
        //                                                                          //
        //              Input parameters:                                           //
        //                      CPattern[] patterns - input pattern objects array   //
        //                      int without - number of the pattern that must       //
        //                                       be removed                         //
        //                      int number_patterns - number of all input patterns  //                   
        //                      int[]idem - the number of the most similar pattern  //
        //                      int[]number - number of a pattern which has the same//
        //                                      similarity value                    //
        //                      int[] value - similarity value                      //  
        //                                    (dot product/Hamming distance)        //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Find the max. similarity value in the pattern collection //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public static int findSimilar(CPattern[] patterns, int without, int number_patterns, int[] number, int[] idem, int[] value)
        {
            number[0] = 0;
            idem[0]   = 0;
            value[0]  = 0;
                                    
            int j = 0;

            for (int i = 0; i < number_patterns; i++)
            {
                if (i != without)
                {
                    number[0] = i;
                    value[0] = patterns[i].similarity;

                    j++;

                    break;
                }
            }

            if (j == 0)
                return -1;
            else
                j = 0;

            if (FLAG_SIMILARITY == 1)
            {
                for (int i = 0; i < number_patterns; i++)
                {
                    if (patterns[i].similarity > value[0] && i != without)
                    {
                        value[0] = patterns[i].similarity;
                        number[0] = i;
                    }
                }
            }
            
            if (FLAG_SIMILARITY == 2)
            {
                 for (int i = 0; i < number_patterns; i++)
                {
                    if (patterns[i].similarity < value[0] && i != without)
                    {
                        value[0] = patterns[i].similarity;
                        number[0] = i;
                    }
                }
            }

            for (int i = 0; i < number_patterns; i++)
            {
                if (patterns[number[0]].similarity == patterns[i].similarity && i != without)
                {
                    idem[0] += 1;
                    number[j++] = i;
                }
            }

            return 1;
        }
    }
}