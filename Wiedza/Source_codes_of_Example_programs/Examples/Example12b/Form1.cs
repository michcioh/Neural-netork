//----------------------------------------------------------------------------------//
//                                                                                  //
//  File name:                  Form1.cs                                            //
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
using System.IO;
using System.Windows.Forms;

using DrawPattern;
using Pattern;
using Hopfield;

namespace RTadeusiewicz.NN.Example12b
{
    public partial class Form1 : Form
    {
        static int MAX_PATTERNS = 20;       //maximum number of patterns = MAX_PATTERN_ROW * MAX_ROW
        static int MAX_PATTERN_ROW = 10;    //maximum number of patterns in one row in picture box
        static int MAX_ROW = 2;             //maximum number of patterns in one column in picture box

        int SIZE_PATTERN_ROW = 8;           //dimension of a pattern in x direction
        int SIZE_PATTERN_COLUMN = 12;      //dimension of a pattern in y direction

        int SIZE_PIXEL = 3;                 //size of a pixel for input and output patterns
        int SIZE_PIXEL_SELECT = 14;         //size of a pixel for selected input and output pattern

        int START_X = 10;                   //start x for picture boxes -> input patterns (max 20) and output patterns
        int START_Y = 20;                   //start y for picture boxes -> input patterns (max 20) and output patterns

        int DELTA_X = 20;                   //x - translation 
        int DELTA_Y = 40;                   //y - translation 

        int DELTA_TEXT = 15;                //translation for text

        int BEFORE_SELECT_PATTERN_INPUT = 0;            //index before selected input pattern
        int CURRENT_SELECT_PATTERN_INPUT = 0;           //index - current selected input pattern 
        int CURRENT_SELECT_PATTERN_INPUT_TEMP = 0;      //temporary index

        int BEFORE_SELECT_PATTERN_OUTPUT = 0;           //index before selected output pattern
        int CURRENT_SELECT_PATTERN_OUTPUT = 0;          //index - current selected output pattern 

        int COUNTER_PATTERNS_INPUT = 0;                 //current number of input patterns
        int COUNTER_PATTERNS_INPUT_TEMP = 0;            //temporary counter

        int index_i_in = 0;                             //==COUNTER_PATTERNS_INPUT
        int index_j_in = 0;                             //number of rows
        int index_k_in = 0;                             //number of patterns in both rows

        int COUNTER_PATTERNS_OUTPUT = 0;                //current number of output patterns
        int index_i_out = 0;                            //==COUNTER_PATTERNS_OUTPUT
        int index_j_out = 0;                            //number of rows
        int index_k_out = 0;                            //number of patterns in both rows

        int MAX_ITERATIONS = 20;                        // !!! this can be for example 10

        CDrawPattern drawPattern1 = new CDrawPattern(); //draw object for input patterns
        CDrawPattern drawPattern2 = new CDrawPattern(); //draw object for selected input pattern
        CDrawPattern drawPattern3 = new CDrawPattern(); //draw object for output patterns
        CDrawPattern drawPattern4 = new CDrawPattern(); //draw object for selected output pattern

        CPattern[] Pattern1 = new CPattern[MAX_PATTERNS]; //object array for input patterns
        CPattern[] Pattern2 = new CPattern[MAX_PATTERNS]; //object array for output patterns

        CPattern[] PatternTEMP = new CPattern[MAX_PATTERNS]; //temporary object array

        int[,] TEMP_PATTERN;    // temporary pattern array
        int[,] SAVE_PATTERN;    // temporary pattern array
        int[,] PATTERN;    // temporary pattern array


        int FLAG_SAVE_REMOVE;   //FLAG -> 1 - save //2 - remove
        int FLAG_SIMILARITY;    //FLAG -> 1 - Dot Product //2 - Hamming code
        bool FLAG_CURRENT_SELECT_INPUT;  //FLAG -> yes or not - selected
        bool FLAG_CURRENT_SELECT_INPUT_TEMP;  // TEMPORARY FLAG
        bool FLAG_CURRENT_SELECT_OUTPUT; //FLAG -> yes or not - selected

        bool FLAG_HEB;

        CHopfield hopfield1 = new CHopfield(); // Hopfield network object

        string LAST_PATH; //last path where file with patterns has been saved or loaded

        public Form1()
        {                        
            InitializeComponent();

            LAST_PATH = "c:\\";

            //input patterns and select input pattern
            drawPattern1.createScene(pictureBox1);
            drawPattern2.createScene(pictureBox2);

            Point point_s = new Point(0, 0);
            drawPattern2.drawPattern(pictureBox2, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

            //output patterns and select output pattern
            drawPattern3.createScene(pictureBox3);
            drawPattern4.createScene(pictureBox4);
            
            drawPattern4.drawPattern(pictureBox4, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

            radioButton1.Checked = true;
            textBox2.Enabled = false;;

            textBox1.MaxLength = 1;
            textBox2.MaxLength = 1;                     

            textBox5.MaxLength = 2;
            textBox5.AppendText("1");

            textBox6.MaxLength = 2;

            radioButton5.Checked = true;
            
            button17.Enabled = false;
            button18.Enabled = false;

            TEMP_PATTERN = new int[SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN];
            SAVE_PATTERN = new int[SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN];
            PATTERN = new int[SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN];

            FLAG_SIMILARITY = 1;

            FLAG_CURRENT_SELECT_INPUT = false;
            FLAG_CURRENT_SELECT_OUTPUT = false;

            //select input pattern////////////////
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            comboBox1.Enabled = false;
            ///////////////////////////////////////

            button3.Enabled = false;
            button9.Enabled = false;                                  
            
            FLAG_HEB = false;
        }

        /*********************************************************************************/
        /*                          radio button: Letter:                                */
        /*********************************************************************************/
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
        }

        /*********************************************************************************/
        /*                          radio button: Digit:                                 */
        /*********************************************************************************/
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox1.Enabled = false;
        }

        /*********************************************************************************/
        /*                         button: Add                                           */
        /*********************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {         
            Point point_s = new Point(0, 0);
            Point point_e = new Point(0, 0);
            Point numberPoint = new Point(0, 0);

            string[] text = new string[1];

            if (radioButton1.Checked == true)
            {                
                text = textBox1.Lines;

                if (text.Length == 0)
                {
                    MessageBox.Show("Wrong letter.", "Message");
                    return;
                }

                if (!((text[0][0] >= 'A' && text[0][0] <= 'Z') || (text[0][0] >= 'a' && text[0][0] <= 'z')))
                {
                    MessageBox.Show("Wrong letter.", "Message");
                    return;
                }
            }
            else
            {
                text = textBox2.Lines;

                if (text.Length == 0)
                {
                    MessageBox.Show("Wrong digit.", "Message");
                    return;
                }
                
                if (text[0][0] < '0' || text[0][0] > '9')
                {
                    MessageBox.Show("Wrong digit.", "Message");
                    return;
                }
            }
                    
            if (COUNTER_PATTERNS_INPUT < MAX_PATTERNS)
            {
                index_i_in = COUNTER_PATTERNS_INPUT;

                if (index_j_in == MAX_PATTERN_ROW)
                {
                    index_j_in = 0;
                    index_k_in++;
                }

                point_s.X = index_j_in * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_in * DELTA_X;
                point_s.Y = index_k_in * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_in * DELTA_Y;

                point_e.X = (index_j_in + 1) * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_in * DELTA_X;
                point_e.Y = (index_k_in + 1) * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_in * DELTA_Y;

                index_j_in++;               

                Pattern1[index_i_in] = new CPattern(point_s, point_e, text[0][0], SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN);

                drawPattern1.drawPattern(pictureBox1, Pattern1[index_i_in].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, point_s, Color.Green, Color.Green, true, false);

                COUNTER_PATTERNS_INPUT++;

                //draw number pattern
                numberPoint.X = point_s.X;
                numberPoint.Y = point_s.Y - DELTA_TEXT;
                drawPattern1.drawNumber(pictureBox1, numberPoint, (index_i_in + 1).ToString(), Color.Blue, 0);

                if (FLAG_CURRENT_SELECT_INPUT == true)
                {
                    //draw similarity patterns////////////////////////////////////////////////////////////////////////////////////            
                    for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                    {
                        numberPoint.X = Pattern1[j].start.X;
                        numberPoint.Y = Pattern1[j].end.Y;

                        Pattern1[j].similarity = CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                        drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                        drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                    int[] number_max_similarity = new int[MAX_PATTERNS];
                    int[] value_max_similarity = new int[1];
                    int[] number_idem = new int[1];

                    comboBox1.Items.Clear();
                    comboBox1.ResetText();

                    textBox7.Clear();

                    CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                    if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                    {
                        for (int l = 0; l < number_idem[0]; l++)
                        {
                            comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                        }

                        comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                        comboBox1.Sorted = true;

                        textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
                else
                {
                    CURRENT_SELECT_PATTERN_INPUT = COUNTER_PATTERNS_INPUT - 1;
                }
            }
            else
            {
                MessageBox.Show("Too many input patterns.", "Message");
                return;
            }

            pictureBox1.Refresh();

            button15.Enabled = false;
            button16.Enabled = true;            
            button3.Enabled = true;

            button17.Enabled = true;
            if (FLAG_HEB == true)
            {
                button18.Enabled = true;
            }
        }

        /*********************************************************************************/
        /*                          button: Generate                                     */
        /*********************************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            int number, i, j, orth1, orth2, orth3, orth_i, orth_l, orth_s;
            int[, ] pattern    = new int[SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN];
            
            int[, ] orthogonal = new int[33, 96];

            int[] v3 = new int[3];
            int[, ] v23 = new int[2, 6];

            int[, ] v43 = new int[4, 12];

            int[, ] v83 = new int[8, 24];
   
            int[, ] v163 = new int[16, 48];

            Point point_s = new Point(0, 0);
            Point point_e = new Point(0, 0);
            Point numberPoint = new Point(0, 0);

            string[] text = new string[1];

            text = textBox5.Lines;

            if (text.Length == 0)
            {
                MessageBox.Show("Wrong number of patterns.", "Message");
                return;
            }

            try
            {
                number = Convert.ToInt32(text[0]);  // number of patterns to generate automatically
            }
            catch (Exception ee)
            {
                MessageBox.Show("Wrong number of patterns.", "Message");
                return;
            }

            if (COUNTER_PATTERNS_INPUT + number > MAX_PATTERNS)   //   number of input patterns + automat. gener. <= 20
            {
                MessageBox.Show("Wrong number of patterns.", "Message");
                return;
            }

            Random rnd = new Random();

// Generate 20 mutually orthogonal patterns 
      
    for (orth1 = 0; orth1 < 3; orth1++)
      v3[orth1] = 1;

    for (orth1 = 0; orth1 < 3; orth1++)
     {
      v23 [0, orth1] = v3[orth1];
      v23 [0, orth1 + 3] = v3[orth1];
      v23 [1, orth1] = v3[orth1];
      v23 [1, orth1 + 3] = -v3[orth1];
      }

     for (orth1 = 0; orth1 < 6; orth1++)
      {
      v43 [0, orth1] = v23[0, orth1];
      v43 [0, orth1 + 6] = v23[0, orth1];
      v43 [1, orth1] = v23[0, orth1];
      v43 [1, orth1 + 6] = -v23[0, orth1];

      v43 [2, orth1] = v23[1, orth1];
      v43 [2, orth1 + 6] = v23[1, orth1];
      v43 [3, orth1] = v23[1, orth1];
      v43 [3, orth1 + 6] = -v23[1, orth1];
      }

    for (orth1 = 0; orth1 < 12; orth1++)
      for (orth2 = 0; orth2 < 8; orth2 = orth2 + 2)
     {
      orth3 = (orth2 + 1) / 2;
      v83 [orth2, orth1] = v43[orth3, orth1];
      v83 [orth2, orth1 + 12] = v43[orth3, orth1];
      v83 [orth2 + 1, orth1] = v43[orth3, orth1];
      v83 [orth2 + 1, orth1 + 12] = -v43[orth3, orth1];
     }
      
    for (orth1 = 0; orth1 < 24; orth1++)
      for (orth2 = 0; orth2 < 16; orth2 = orth2 + 2)
      {
      orth3 = (orth2 + 1) / 2;
      v163 [orth2, orth1] = v83[orth3, orth1];
      v163 [orth2, orth1 + 24] = v83[orth3, orth1];
      v163 [orth2 + 1, orth1] = v83[orth3, orth1];
      v163 [orth2 + 1, orth1 + 24] = -v83[orth3, orth1];
       }
         
      for (orth1 = 0; orth1 < 48; orth1++)
      for (orth2 = 0; orth2 < 32; orth2 = orth2 + 2)  
      {
       orth3 = (orth2 +1) / 2;
      orthogonal [orth2, orth1] = v163[orth3, orth1];
      orthogonal [orth2, orth1 + 48] = v163[orth3, orth1];
      orthogonal [orth2 + 1, orth1] = v163[orth3, orth1];
      orthogonal [orth2 + 1, orth1 + 48] = -v163[orth3, orth1];
       }

      for (orth_i = 0; orth_i < 96; orth_i++)    
        for (orth_l = 0; orth_l < 32; orth_l++)
          {
           if (orthogonal [orth_l, orth_i] > 0)
               orthogonal [orth_l, orth_i] = 1;
           else
               orthogonal [orth_l, orth_i] = 0;
          }

    orth_s = COUNTER_PATTERNS_INPUT;   // Number of input patterns - that have been added to the net 
                                       // before asking for automatic generation of other patterns  (== number)

            for (i = 0; i < number; i++)
            {                                    //create and draw patterns
               
                if (COUNTER_PATTERNS_INPUT < MAX_PATTERNS)
                {
                    index_i_in = COUNTER_PATTERNS_INPUT;

                    if (index_j_in == MAX_PATTERN_ROW)
                    {
                        index_j_in = 0;
                        index_k_in++;
                    }

                    //calculate start and end pixel
                    point_s.X = index_j_in * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_in * DELTA_X;
                    point_s.Y = index_k_in * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_in * DELTA_Y;

                    point_e.X = (index_j_in + 1) * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_in * DELTA_X;
                    point_e.Y = (index_k_in + 1) * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_in * DELTA_Y;

                    index_j_in++;

// Draw generated mutually orthogonal patterns (number)

if (orth_s == 0)   // i.e. COUNTER_PATTERNS_INPUT == 0 and index_i_in == 0
                   // It means that there have not been yet any letter or digit added to net 
  {
   orth1 = 0;
   orth_i = i + 1;  // There are 32 orthogonal vectors. Start index from for example the orth_i

   for (orth2 = 0; orth2 < 8; orth2++)    
    for (orth3 = 0; orth3 < 12; orth3++)
      pattern[orth2, orth3] = orthogonal [orth_i, orth1++];
  }
  else 
                     // Generate some (== number)  pseudo-random patterns
  
     CPattern.generatePatternPRandom(pattern, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, rnd);

                    Pattern1[index_i_in] = new CPattern(point_s, point_e, pattern, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN);

                    drawPattern1.drawPattern(pictureBox1, Pattern1[index_i_in].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, point_s, Color.Green, Color.Green, true, false);

                    COUNTER_PATTERNS_INPUT++;

                    //draw number pattern
                    numberPoint.X = point_s.X;
                    numberPoint.Y = point_s.Y - DELTA_TEXT;
                    drawPattern1.drawNumber(pictureBox1, numberPoint, (index_i_in + 1).ToString(), Color.Blue, 0);                   
                }

                if (FLAG_CURRENT_SELECT_INPUT == true)
                {
                    //draw similarity patterns////////////////////////////////////////////////////////////////////////////////////            
                    for (j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                    {
                        numberPoint.X = Pattern1[j].start.X;
                        numberPoint.Y = Pattern1[j].end.Y;

                        Pattern1[j].similarity = CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                        drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                        drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                    int[] number_max_similarity = new int[MAX_PATTERNS];
                    int[] value_max_similarity = new int[1];
                    int[] number_idem = new int[1];

                    comboBox1.Items.Clear();
                    comboBox1.ResetText();

                    textBox7.Clear();

                    CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                    if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                    {
                        for (int l = 0; l < number_idem[0]; l++)
                        {
                            comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                        }

                        comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                        comboBox1.Sorted = true;

                        textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
                else
                {
                    CURRENT_SELECT_PATTERN_INPUT = COUNTER_PATTERNS_INPUT - 1;
                }
            }

            pictureBox1.Refresh();

            button16.Enabled = true;
            button3.Enabled = true;

            button17.Enabled = true;
            if (FLAG_HEB == true)
            {
                button18.Enabled = true;
            }
        }

        /*********************************************************************************/
        /*                                button: Load                 (input patterns)  */
        /*********************************************************************************/
        private void button5_Click(object sender, EventArgs e)
        {
            int[, ,] patterns;
            int[,] pattern;
            int number_patterns;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            string[] path;

            openFileDialog1.InitialDirectory = LAST_PATH;
            openFileDialog1.Filter = "patterns files (*.ptn)|*.ptn|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Refresh();

                path = openFileDialog1.FileNames;
                LAST_PATH = path[0];                

                //READ//////////////////////////////////////////           
                try
                {
                    StreamReader read = new StreamReader(path[0]);
                    string buffer;
                    string[] row;

                    if (File.Exists(path[0]))
                    {

                        buffer = read.ReadLine();

                        number_patterns = Convert.ToInt32(buffer);
                        if (COUNTER_PATTERNS_INPUT + number_patterns > MAX_PATTERNS)
                        {
                            MessageBox.Show("Too many patterns in a file!", "Message");
                            return;
                        }

                        patterns = new int[number_patterns, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN];
                        pattern = new int[SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN];
                        row = new string[SIZE_PATTERN_ROW * SIZE_PATTERN_COLUMN];

                        for (int m = 0; m < number_patterns; m++)
                        {
                            for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                            {
                                buffer = read.ReadLine();
                                row = buffer.Split(' ');

                                for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                                {
                                    patterns[m, i, j] = Convert.ToInt32(row[j]);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("File doesn't exist.", "Message");
                        return;
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Incorrect contents of a file.", "Message");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select a file.", "Message");
                return;
            }

            textBox3.Clear();
            textBox3.AppendText(path[0]);

            //create and draw patterns///////////////////////////////////////////////////////////////////////////////////////////
            Point point_s = new Point(0, 0);
            Point point_e = new Point(0, 0);
            Point numberPoint = new Point(0, 0);
            for (int i = COUNTER_PATTERNS_INPUT; i < COUNTER_PATTERNS_INPUT + number_patterns; i++)
            {
                index_i_in = i;

                if (index_j_in == MAX_PATTERN_ROW)
                {
                    index_j_in = 0;
                    index_k_in++;
                }

                point_s.X = index_j_in * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_in * DELTA_X;
                point_s.Y = index_k_in * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_in * DELTA_Y;

                point_e.X = (index_j_in + 1) * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_in * DELTA_X;
                point_e.Y = (index_k_in + 1) * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_in * DELTA_Y;

                index_j_in++;

                for (int k = 0; k < SIZE_PATTERN_ROW; k++)
                    for (int l = 0; l < SIZE_PATTERN_COLUMN; l++)
                        pattern[k, l] = patterns[i - COUNTER_PATTERNS_INPUT, k, l];


                Pattern1[index_i_in] = new CPattern(point_s, point_e, pattern, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN);

                drawPattern1.drawPattern(pictureBox1, Pattern1[index_i_in].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, point_s, Color.Green, Color.Green, true, false);

                //draw number pattern
                numberPoint.X = point_s.X;
                numberPoint.Y = point_s.Y - DELTA_TEXT;
                drawPattern1.drawNumber(pictureBox1, numberPoint, (index_i_in + 1).ToString(), Color.Blue, 0);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            COUNTER_PATTERNS_INPUT += number_patterns;

            if (FLAG_CURRENT_SELECT_INPUT == true)
            {
                //draw similarity patterns////////////////////////////////////////////////////////////////////////////////////            
                for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                {
                    numberPoint.X = Pattern1[j].start.X;
                    numberPoint.Y = Pattern1[j].end.Y;

                    Pattern1[j].similarity = CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                    drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                    drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                int[] number_max_similarity = new int[MAX_PATTERNS];
                int[] value_max_similarity = new int[1];
                int[] number_idem = new int[1];

                comboBox1.Items.Clear();
                comboBox1.ResetText();

                textBox7.Clear();

                CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                {
                    for (int l = 0; l < number_idem[0]; l++)
                    {
                        comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                    }

                    comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                    comboBox1.Sorted = true;

                    textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else
            {
                CURRENT_SELECT_PATTERN_INPUT = COUNTER_PATTERNS_INPUT - 1;
            }

            pictureBox1.Refresh();

            button15.Enabled = false;
            button16.Enabled = true;
            button3.Enabled = true;

            button17.Enabled = true;
            if (FLAG_HEB == true)
            {
                button18.Enabled = true;
            }
        }       

        /*********************************************************************************/
        /*                          event for pictureBox1 (select pattern)               */
        /*********************************************************************************/
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point_s = new Point(0, 0);
            Point numberPoint = new Point(0, 0);

            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < COUNTER_PATTERNS_INPUT; i++)
                {
                    if (e.Location.X > Pattern1[i].start.X && e.Location.X < Pattern1[i].end.X &&
                        e.Location.Y > Pattern1[i].start.Y && e.Location.Y < Pattern1[i].end.Y)
                    {
                        drawPattern1.drawPattern(pictureBox1, Pattern1[BEFORE_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[BEFORE_SELECT_PATTERN_INPUT].start, Color.Green, Color.Green, true, false);

                        CURRENT_SELECT_PATTERN_INPUT = i;
                        
                        drawPattern2.drawPattern(pictureBox2, Pattern1[i].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

                        drawPattern1.drawPattern(pictureBox1, Pattern1[i].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[i].start, Color.Red, Color.Green, true, false);

                        //draw similarity patterns///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                        
                        for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                        {                            
                            numberPoint.X = Pattern1[j].start.X;
                            numberPoint.Y = Pattern1[j].end.Y;

                            Pattern1[j].similarity = CPattern.calcSimilarity(Pattern1[i].PATTERN_XX, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                            drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                            drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                        }
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                        int[] number_max_similarity = new int[MAX_PATTERNS];
                        int[] value_max_similarity = new int[1];
                        int[] number_idem = new int[1];

                        comboBox1.Items.Clear();
                        comboBox1.ResetText();

                        textBox7.Clear();

                        CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                        if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                        {
                            for (int l = 0; l < number_idem[0]; l++)
                            {
                                comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                            }

                            comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                            comboBox1.Sorted = true;

                            textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                        }
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        
                        BEFORE_SELECT_PATTERN_INPUT = i;
                        FLAG_CURRENT_SELECT_INPUT = true;

                        if (FLAG_CURRENT_SELECT_OUTPUT == true)
                        {
                            textBox8.Clear();
                            textBox8.AppendText(String.Format("{0}", CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern2[CURRENT_SELECT_PATTERN_OUTPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY)));

                        }

                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = false;
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        comboBox1.Enabled = true;

                        pictureBox1.Refresh();
                        pictureBox2.Refresh();

                        //output patterns and select output pattern//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        if (FLAG_CURRENT_SELECT_OUTPUT == false)
                        {
                            drawPattern3.createScene(pictureBox3);
                            drawPattern4.createScene(pictureBox4);

                            drawPattern4.drawPattern(pictureBox4, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);
                            pictureBox3.Refresh();
                            pictureBox3.Refresh();

                            COUNTER_PATTERNS_OUTPUT = 0;
                            CURRENT_SELECT_PATTERN_OUTPUT = 0;
                            BEFORE_SELECT_PATTERN_OUTPUT = 0;
                        }
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        return;
                    }                   
                }

                if (COUNTER_PATTERNS_INPUT > 0)
                {
                    drawPattern1.drawPattern(pictureBox1, Pattern1[BEFORE_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[BEFORE_SELECT_PATTERN_INPUT].start, Color.Green, Color.Green, true, false);

                    drawPattern2.drawPattern(pictureBox2, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

                    for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                    {
                        numberPoint.X = Pattern1[j].start.X;
                        numberPoint.Y = Pattern1[j].end.Y;
                        drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                    }

                    CURRENT_SELECT_PATTERN_INPUT = COUNTER_PATTERNS_INPUT - 1;
                }

                pictureBox1.Refresh();
                pictureBox2.Refresh();
                
                comboBox1.Items.Clear();
                comboBox1.ResetText();

                textBox7.Clear();

                textBox8.Clear();

                //select input pattern////////////////
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                comboBox1.Enabled = false;
                ///////////////////////////////////////

                FLAG_CURRENT_SELECT_INPUT = false;     
             
                //output patterns and select output pattern/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                drawPattern3.createScene(pictureBox3);
                drawPattern4.createScene(pictureBox4);

                drawPattern4.drawPattern(pictureBox4, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);
                pictureBox3.Refresh();
                pictureBox3.Refresh();

                COUNTER_PATTERNS_OUTPUT = 0;
                FLAG_CURRENT_SELECT_OUTPUT = false;
                CURRENT_SELECT_PATTERN_OUTPUT = 0;
                BEFORE_SELECT_PATTERN_OUTPUT = 0;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
        }

        /*********************************************************************************/
        /*                          event for pictureBox3 (select pattern)               */
        /*********************************************************************************/
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Point point_s = new Point(0, 0);
            Point numberPoint = new Point(0, 0);

            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < COUNTER_PATTERNS_OUTPUT; i++)
                {
                    if (e.Location.X > Pattern2[i].start.X && e.Location.X < Pattern2[i].end.X &&
                        e.Location.Y > Pattern2[i].start.Y && e.Location.Y < Pattern2[i].end.Y)
                    {
                        drawPattern3.drawPattern(pictureBox3, Pattern2[BEFORE_SELECT_PATTERN_OUTPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern2[BEFORE_SELECT_PATTERN_OUTPUT].start, Color.Green, Color.Green, true, false);

                        CURRENT_SELECT_PATTERN_OUTPUT = i;

                        drawPattern4.drawPattern(pictureBox4, Pattern2[i].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

                        drawPattern3.drawPattern(pictureBox3, Pattern2[i].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern2[i].start, Color.Red, Color.Green, true, false);

                        //draw similarity patterns///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                        
                        for (int j = 0; j < COUNTER_PATTERNS_OUTPUT; j++)
                        {
                            numberPoint.X = Pattern2[j].start.X;
                            numberPoint.Y = Pattern2[j].end.Y;

                            Pattern2[j].similarity = CPattern.calcSimilarity(Pattern2[i].PATTERN_XX, Pattern2[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                            drawPattern3.clear(pictureBox3, numberPoint, 10, 5, 2);
                            drawPattern3.drawNumber(pictureBox3, numberPoint, Pattern2[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                        }
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                        

                        BEFORE_SELECT_PATTERN_OUTPUT = i;
                        FLAG_CURRENT_SELECT_OUTPUT = true;

                        if (FLAG_CURRENT_SELECT_INPUT == true)
                        {
                            textBox8.Clear();
                            textBox8.AppendText(String.Format("{0}", CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern2[CURRENT_SELECT_PATTERN_OUTPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY)));
                        }

                        pictureBox3.Refresh();
                        pictureBox4.Refresh();

                        return;
                    }
                }

                if (COUNTER_PATTERNS_OUTPUT > 0)
                {
                    drawPattern3.drawPattern(pictureBox3, Pattern2[BEFORE_SELECT_PATTERN_OUTPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern2[BEFORE_SELECT_PATTERN_OUTPUT].start, Color.Green, Color.Green, true, false);

                    drawPattern4.drawPattern(pictureBox4, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

                    for (int j = 0; j < COUNTER_PATTERNS_OUTPUT; j++)
                    {
                        numberPoint.X = Pattern2[j].start.X;
                        numberPoint.Y = Pattern2[j].end.Y;
                        drawPattern3.clear(pictureBox3, numberPoint, 10, 5, 2);
                    }
                }

                pictureBox3.Refresh();
                pictureBox4.Refresh();

                textBox8.Clear();
                FLAG_CURRENT_SELECT_OUTPUT = false;
            }
        }

        /*********************************************************************************/
        /*                          button: Inverse                                      */
        /*********************************************************************************/
        private void button6_Click(object sender, EventArgs e)
        {
            Point point_s = new Point(0, 0);

            if (COUNTER_PATTERNS_INPUT == 0)
                return;

            for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                    TEMP_PATTERN[i, j] = Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[i, j];

            CPattern.inversePattern(TEMP_PATTERN, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN);
            drawPattern2.drawPattern(pictureBox2, TEMP_PATTERN, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

            //draw similarity patterns
            Point numberPoint = new Point(0, 0);

            for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
            {
                numberPoint.X = Pattern1[j].start.X;
                numberPoint.Y = Pattern1[j].end.Y;

                Pattern1[j].similarity = CPattern.calcSimilarity(TEMP_PATTERN, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
            }

            //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
            int[] number_max_similarity = new int[MAX_PATTERNS];
            int[] value_max_similarity = new int[1];
            int[] number_idem = new int[1];

            comboBox1.Items.Clear();
            comboBox1.ResetText();

            textBox7.Clear();

            CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
            if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
            {
                for (int l = 0; l < number_idem[0]; l++)
                {
                    comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                }

                comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                comboBox1.Sorted = true;

                textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            pictureBox1.Refresh();
            pictureBox2.Refresh();

            button8.Enabled = true;
        }

        /*********************************************************************************/
        /*                          button: Noise                                        */
        /*********************************************************************************/
        private void button7_Click(object sender, EventArgs e)
        {
            Point point_s = new Point(0, 0);
            Point numberPoint = new Point(0, 0);

            int percent;

            string[] text = new string[1];

            if (COUNTER_PATTERNS_INPUT == 0)
                return;

            ////////////////get %///////////////////////
            text = textBox6.Lines;

            if (text.Length == 0)
            {
                MessageBox.Show("Wrong percentage (%).", "Message");
                return;
            }

            try
            {
                percent = Convert.ToInt32(text[0]);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Wrong percentage (%).", "Message");
                return;
            }

            if (percent > 100)
            {
                MessageBox.Show("Wrong percentage (%).", "Message");
                return;
            }
            ///////////////////////////////////////////////
            for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                    TEMP_PATTERN[i, j] = Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[i, j];

            CPattern.noisePattern(TEMP_PATTERN, percent, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN);
            drawPattern2.drawPattern(pictureBox2, TEMP_PATTERN, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

            //draw similarity patterns
            for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
            {
                numberPoint.X = Pattern1[j].start.X;
                numberPoint.Y = Pattern1[j].end.Y;

                Pattern1[j].similarity = CPattern.calcSimilarity(TEMP_PATTERN, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
            }

            //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
            int[] number_max_similarity = new int[MAX_PATTERNS];
            int[] value_max_similarity = new int[1];
            int[] number_idem = new int[1];

            comboBox1.Items.Clear();
            comboBox1.ResetText();

            textBox7.Clear();

            CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
            if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
            {
                for (int l = 0; l < number_idem[0]; l++)
                {
                    comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                }

                comboBox1.Sorted = true;
                comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            pictureBox1.Refresh();
            pictureBox2.Refresh();

            button8.Enabled = true;
        }

        /*********************************************************************************/
        /*                          button: Save                                         */
        /*********************************************************************************/
        private void button8_Click(object sender, EventArgs e)
        {
            if (COUNTER_PATTERNS_INPUT == 0)
                return;

            for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                    SAVE_PATTERN[i, j] = Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[i, j];

            for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                    Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[i, j] = TEMP_PATTERN[i, j];

            drawPattern1.drawPattern(pictureBox1, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[CURRENT_SELECT_PATTERN_INPUT].start, Color.White, Color.White, false, false);
            drawPattern1.drawPattern(pictureBox1, Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[CURRENT_SELECT_PATTERN_INPUT].start, Color.Red, Color.Green, true, false);

            pictureBox1.Refresh();

            FLAG_SAVE_REMOVE = 1;

            button8.Enabled = false;
            button15.Enabled = true;
        }

        /*********************************************************************************/
        /*                          button: Undo last operation                                   */
        /*********************************************************************************/
        private void button15_Click(object sender, EventArgs e)
        {
            Point point_s = new Point(0, 0);
            Point numberPoint = new Point(0, 0);

            if (FLAG_SAVE_REMOVE == 1)
            {
                if (COUNTER_PATTERNS_INPUT == 0)
                    return;

                for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                    for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                        Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[i, j] = SAVE_PATTERN[i, j];

                drawPattern1.drawPattern(pictureBox1, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[CURRENT_SELECT_PATTERN_INPUT].start, Color.White, Color.White, false, false);
                drawPattern1.drawPattern(pictureBox1, Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[CURRENT_SELECT_PATTERN_INPUT].start, Color.Red, Color.Green, true, false);

                //draw similarity patterns
                for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                {
                    numberPoint.X = Pattern1[j].start.X;
                    numberPoint.Y = Pattern1[j].end.Y;

                    Pattern1[j].similarity = CPattern.calcSimilarity(TEMP_PATTERN, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                    drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                    drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                }

                //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                int[] number_max_similarity = new int[MAX_PATTERNS];
                int[] value_max_similarity = new int[1];
                int[] number_idem = new int[1];

                comboBox1.Items.Clear();
                comboBox1.ResetText();

                textBox7.Clear();

                CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                {
                    for (int l = 0; l < number_idem[0]; l++)
                    {
                        comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                    }

                    comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                    comboBox1.Sorted = true;

                    textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                
                if (FLAG_CURRENT_SELECT_INPUT == true)
                {
                    drawPattern2.drawPattern(pictureBox2, Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);
                }

                button8.Enabled = true;
                button15.Enabled = false;
            }

            if (FLAG_SAVE_REMOVE == 2)
            {
                index_i_in = 0;
                index_j_in = 0;
                index_k_in = 0;

                COUNTER_PATTERNS_INPUT = COUNTER_PATTERNS_INPUT_TEMP;
                CURRENT_SELECT_PATTERN_INPUT = CURRENT_SELECT_PATTERN_INPUT_TEMP;
                BEFORE_SELECT_PATTERN_INPUT = CURRENT_SELECT_PATTERN_INPUT_TEMP;
                FLAG_CURRENT_SELECT_INPUT = FLAG_CURRENT_SELECT_INPUT_TEMP;

                //MessageBox.Show(String.Format("{0}", CURRENT_SELECT_PATTERN_INPUT));

                for (int i = COUNTER_PATTERNS_INPUT - 1; i >= (CURRENT_SELECT_PATTERN_INPUT + 1); i--)
                {
                    for (int j = 0; j < SIZE_PATTERN_ROW; j++)
                    {
                        for (int k = 0; k < SIZE_PATTERN_COLUMN; k++)
                        {
                            Pattern1[i].PATTERN_XX[j, k] = Pattern1[i-1].PATTERN_XX[j, k];
                        }
                    }
                }

                for (int j = 0; j < SIZE_PATTERN_ROW; j++)
                {
                    for (int k = 0; k < SIZE_PATTERN_COLUMN; k++)
                    {
                        Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[j, k] = PATTERN[j, k];
                    }
                }

                //clear -> input patterns and select input pattern/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                drawPattern1.createScene(pictureBox1);
                drawPattern2.createScene(pictureBox2);

                drawPattern2.drawPattern(pictureBox2, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, Point.Empty, Color.Green, Color.Green, true, true);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                {
                    index_i_in = j;

                    if (index_j_in == MAX_PATTERN_ROW)
                    {
                        index_j_in = 0;
                        index_k_in++;
                    }

                    index_j_in++;

                    drawPattern1.drawPattern(pictureBox1, Pattern1[index_i_in].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[index_i_in].start, Color.Green, Color.Green, true, false);

                    //draw number pattern
                    numberPoint.X = Pattern1[index_i_in].start.X;
                    numberPoint.Y = Pattern1[index_i_in].start.Y - DELTA_TEXT;
                    drawPattern1.drawNumber(pictureBox1, numberPoint, (index_i_in + 1).ToString(), Color.Blue, 0);
                }

                if (FLAG_CURRENT_SELECT_INPUT == true)
                {
                    drawPattern1.drawPattern(pictureBox1, Pattern1[BEFORE_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[BEFORE_SELECT_PATTERN_INPUT].start, Color.Green, Color.Green, true, false);
                    drawPattern2.drawPattern(pictureBox2, Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);
                    drawPattern1.drawPattern(pictureBox1, Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[CURRENT_SELECT_PATTERN_INPUT].start, Color.Red, Color.Green, true, false);

                    //draw similarity patterns
                    for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                    {
                        numberPoint.X = Pattern1[j].start.X;
                        numberPoint.Y = Pattern1[j].end.Y;

                        Pattern1[j].similarity = CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                        drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                        drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                    }

                    //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                    int[] number_max_similarity = new int[MAX_PATTERNS];
                    int[] value_max_similarity = new int[1];
                    int[] number_idem = new int[1];

                    comboBox1.Items.Clear();
                    comboBox1.ResetText();

                    textBox7.Clear();

                    CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                    if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                    {
                        for (int l = 0; l < number_idem[0]; l++)
                        {
                            comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                        }

                        comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                        comboBox1.Sorted = true;

                        textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }

                button3.Enabled = true;
            }

            pictureBox1.Refresh();
            pictureBox2.Refresh();

            button15.Enabled = false;
            button16.Enabled = true;
        }

        /*********************************************************************************/
        /*                          button: Remove                                       */
        /*********************************************************************************/
        private void button16_Click(object sender, EventArgs e)
        {
            Point numberPoint = new Point(0, 0);

            if (COUNTER_PATTERNS_INPUT == 0)
                return;

            index_i_in = 0;
            index_j_in = 0;
            index_k_in = 0;
           
            for (int j = 0; j < SIZE_PATTERN_ROW; j++)
            {
                for (int k = 0; k < SIZE_PATTERN_COLUMN; k++)
                {
                    PATTERN[j, k]= Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[j, k];
                }
            }            

            CURRENT_SELECT_PATTERN_INPUT_TEMP = CURRENT_SELECT_PATTERN_INPUT;
            COUNTER_PATTERNS_INPUT_TEMP = COUNTER_PATTERNS_INPUT;
            FLAG_CURRENT_SELECT_INPUT_TEMP = FLAG_CURRENT_SELECT_INPUT;

            for (int i = CURRENT_SELECT_PATTERN_INPUT; i < COUNTER_PATTERNS_INPUT - 1; i++)
            {
                for (int j = 0; j < SIZE_PATTERN_ROW; j++)
                {
                    for (int k = 0; k < SIZE_PATTERN_COLUMN; k++)
                    {
                        Pattern1[i].PATTERN_XX[j,k] = Pattern1[i + 1].PATTERN_XX[j,k];
                    }
                }
            }

            COUNTER_PATTERNS_INPUT -= 1;

            if (COUNTER_PATTERNS_INPUT > 0)
            {
                CURRENT_SELECT_PATTERN_INPUT = COUNTER_PATTERNS_INPUT - 1;
                BEFORE_SELECT_PATTERN_INPUT = COUNTER_PATTERNS_INPUT - 1;
            }
            else
            {
                CURRENT_SELECT_PATTERN_INPUT = 0;
                BEFORE_SELECT_PATTERN_INPUT = 0;
            }

            //clear -> input patterns and select input pattern/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            drawPattern1.createScene(pictureBox1);
            drawPattern2.createScene(pictureBox2);

            drawPattern2.drawPattern(pictureBox2, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, Point.Empty, Color.Green, Color.Green, true, true);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //draw similarity patterns
            for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
            {
                index_i_in = j;

                if (index_j_in == MAX_PATTERN_ROW)
                {
                    index_j_in = 0;
                    index_k_in++;
                }

                index_j_in++;

                drawPattern1.drawPattern(pictureBox1, Pattern1[index_i_in].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, Pattern1[index_i_in].start, Color.Green, Color.Green, true, false);

                //draw number pattern
                numberPoint.X = Pattern1[index_i_in].start.X;
                numberPoint.Y = Pattern1[index_i_in].start.Y - DELTA_TEXT;
                drawPattern1.drawNumber(pictureBox1, numberPoint, (index_i_in + 1).ToString(), Color.Blue, 0);
            }

            pictureBox1.Refresh();
            pictureBox2.Refresh();

            //clear fields
            comboBox1.Items.Clear();
            comboBox1.ResetText();

            textBox7.Clear();

            button15.Enabled = true;

            if (COUNTER_PATTERNS_INPUT == 0)
            {
                button16.Enabled = false;
                button3.Enabled = false;
            }

            //select input pattern////////////////
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            comboBox1.Enabled = false;
            ///////////////////////////////////////

            FLAG_SAVE_REMOVE = 2;
            FLAG_CURRENT_SELECT_INPUT = false;
        }

        /*********************************************************************************/
        /*                          button: Clear                                        */
        /*********************************************************************************/
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            
            COUNTER_PATTERNS_INPUT = 0;
            index_i_in = 0;
            index_j_in = 0;
            index_k_in = 0;

            COUNTER_PATTERNS_OUTPUT = 0;
            index_i_out = 0;
            index_j_out = 0;
            index_k_out = 0;

            drawPattern1.createScene(pictureBox1);
            drawPattern2.createScene(pictureBox2);

            Point point_s = new Point(0, 0);
            drawPattern2.drawPattern(pictureBox2, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

            //output patterns and select output pattern
            drawPattern3.createScene(pictureBox3);
            drawPattern4.createScene(pictureBox4);

            drawPattern4.drawPattern(pictureBox4, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();

            CURRENT_SELECT_PATTERN_INPUT = 0;
            BEFORE_SELECT_PATTERN_INPUT  = 0;

            CURRENT_SELECT_PATTERN_OUTPUT = 0;
            BEFORE_SELECT_PATTERN_OUTPUT = 0;

            FLAG_CURRENT_SELECT_INPUT = false;
            FLAG_CURRENT_SELECT_OUTPUT = false;

            
            comboBox1.Items.Clear();
            comboBox1.ResetText();

            textBox3.Clear();
            textBox7.Clear();
            textBox8.Clear();

            //select input pattern////////////////
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            comboBox1.Enabled = false;
            ///////////////////////////////////////

            button3.Enabled = false;
            button9.Enabled = false;

            button17.Enabled = false;
            button18.Enabled = false;
        }                              
       
        /*********************************************************************************/
        /*                          radio button: Dot product (DP)                       */
        /*********************************************************************************/
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            FLAG_SIMILARITY = 1;

            Point numberPoint = new Point(0, 0);

            if (FLAG_CURRENT_SELECT_INPUT == true)
            {
                //draw similarity patterns////////////////////////////////////////////////////////////////////////////////////            
                for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                {
                    numberPoint.X = Pattern1[j].start.X;
                    numberPoint.Y = Pattern1[j].end.Y;

                    Pattern1[j].similarity = CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                    drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                    drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                int[] number_max_similarity = new int[MAX_PATTERNS];
                int[] value_max_similarity = new int[1];
                int[] number_idem = new int[1];

                comboBox1.Items.Clear();
                comboBox1.ResetText();

                textBox7.Clear();

                CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                {
                    for (int l = 0; l < number_idem[0]; l++)
                    {
                        comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                    }

                    comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                    comboBox1.Sorted = true;

                    textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }

            if (FLAG_CURRENT_SELECT_OUTPUT == true)
            {
                //draw similarity patterns - output
                for (int j = 0; j < COUNTER_PATTERNS_OUTPUT; j++)
                {
                    numberPoint.X = Pattern2[j].start.X;
                    numberPoint.Y = Pattern2[j].end.Y;

                    Pattern2[j].similarity = CPattern.calcSimilarity(Pattern2[CURRENT_SELECT_PATTERN_OUTPUT].PATTERN_XX, Pattern2[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                    drawPattern3.clear(pictureBox3, numberPoint, 10, 5, 2);
                    drawPattern3.drawNumber(pictureBox3, numberPoint, Pattern2[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                }
            }

            if (FLAG_CURRENT_SELECT_INPUT == true && FLAG_CURRENT_SELECT_OUTPUT == true)
            {
                textBox8.Clear();
                textBox8.AppendText(String.Format("{0}", CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern2[CURRENT_SELECT_PATTERN_OUTPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY)));

            }

            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();
        }

        /*********************************************************************************/
        /*                          radio button: Hamming distance (H)                   */
        /*********************************************************************************/
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            FLAG_SIMILARITY = 2;

            Point numberPoint = new Point(0, 0);

            if (FLAG_CURRENT_SELECT_INPUT == true)
            {

                //draw similarity patterns////////////////////////////////////////////////////////////////////////////////////            
                for (int j = 0; j < COUNTER_PATTERNS_INPUT; j++)
                {
                    numberPoint.X = Pattern1[j].start.X;
                    numberPoint.Y = Pattern1[j].end.Y;

                    Pattern1[j].similarity = CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern1[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                    drawPattern1.clear(pictureBox1, numberPoint, 10, 5, 2);
                    drawPattern1.drawNumber(pictureBox1, numberPoint, Pattern1[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //Max Similar/////////////////////////////////////////////////////////////////////////////////////////////////
                int[] number_max_similarity = new int[MAX_PATTERNS];
                int[] value_max_similarity = new int[1];
                int[] number_idem = new int[1];

                comboBox1.Items.Clear();
                comboBox1.ResetText();

                textBox7.Clear();

                CPattern.FLAG_SIMILARITY = FLAG_SIMILARITY;
                if (CPattern.findSimilar(Pattern1, CURRENT_SELECT_PATTERN_INPUT, COUNTER_PATTERNS_INPUT, number_max_similarity, number_idem, value_max_similarity) == 1)
                {
                    for (int l = 0; l < number_idem[0]; l++)
                    {
                        comboBox1.Items.Add(String.Format("{0}", number_max_similarity[l] + 1));
                    }

                    comboBox1.SelectedText = comboBox1.GetItemText(comboBox1.Items[0]);

                    comboBox1.Sorted = true;

                    textBox7.AppendText(String.Format("{0}", value_max_similarity[0]));
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }

            if (FLAG_CURRENT_SELECT_OUTPUT == true)
            {
                //draw similarity patterns - output
                for (int j = 0; j < COUNTER_PATTERNS_OUTPUT; j++)
                {
                    numberPoint.X = Pattern2[j].start.X;
                    numberPoint.Y = Pattern2[j].end.Y;

                    Pattern2[j].similarity = CPattern.calcSimilarity(Pattern2[CURRENT_SELECT_PATTERN_OUTPUT].PATTERN_XX, Pattern2[j].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY);
                    drawPattern3.clear(pictureBox3, numberPoint, 10, 5, 2);
                    drawPattern3.drawNumber(pictureBox3, numberPoint, Pattern2[j].similarity.ToString(), Color.Green, FLAG_SIMILARITY);
                }
            }

            if (FLAG_CURRENT_SELECT_INPUT == true && FLAG_CURRENT_SELECT_OUTPUT == true)
            {
                textBox8.Clear();
                textBox8.AppendText(String.Format("{0}", CPattern.calcSimilarity(Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX, Pattern2[CURRENT_SELECT_PATTERN_OUTPUT].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, FLAG_SIMILARITY)));

            }

            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();
        }
                  
        /*********************************************************************************/
        /*                                button: Save in a file        (input patterns) */
        /*********************************************************************************/
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog1 = new SaveFileDialog();

            string[] path;

            StreamWriter writer;

            openFileDialog1.InitialDirectory = LAST_PATH;
            openFileDialog1.Filter = "pattern files (*.ptn)|*.ptn|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (COUNTER_PATTERNS_INPUT == 0)
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
                   
                path = openFileDialog1.FileNames;

                LAST_PATH = path[0];
                
                try
                {
                    if (File.Exists(path[0]))
                    {
                        writer = new StreamWriter(path[0]);
                    }
                    else
                    {
                        writer = File.CreateText(path[0]);
                    }

                    if (File.Exists(path[0]))
                    {
                        writer.Write("{0}\n", COUNTER_PATTERNS_INPUT);

                        for (int m = 0; m < COUNTER_PATTERNS_INPUT; m++)
                        {
                            for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                            {
                                for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                                {
                                    writer.Write("{0} ", Pattern1[m].PATTERN_XX[i,j]);
                                }

                                writer.Write("\n");
                            }
                        }

                        writer.Close();
                    }                      
                }
                catch (Exception ee) 
                {
                    MessageBox.Show("File has not been saved.", "Message");
                    return;
                }
            }
            else
            {
                MessageBox.Show("File has not been saved.", "Message");
                return;
            }      
        }        

        /*********************************************************************************/
        /*                                button: Save in a file      (output patterns)  */
        /*********************************************************************************/
        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog1 = new SaveFileDialog();

            string[] path;

            StreamWriter writer;

            openFileDialog1.InitialDirectory = LAST_PATH;
            openFileDialog1.Filter = "pattern files (*.ptn)|*.ptn|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (COUNTER_PATTERNS_OUTPUT == 0)
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();

                path = openFileDialog1.FileNames;

                LAST_PATH = path[0];

                try
                {
                    if (File.Exists(path[0]))
                    {
                        writer = new StreamWriter(path[0]);
                    }
                    else
                    {
                        writer = File.CreateText(path[0]);
                    }

                    if (File.Exists(path[0]))
                    {
                        writer.Write("{0} \n", COUNTER_PATTERNS_OUTPUT);

                        for (int m = 0; m < COUNTER_PATTERNS_OUTPUT; m++)
                        {
                            for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                            {
                                for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                                {
                                    writer.Write("{0} ", Pattern2[m].PATTERN_XX[i, j]);
                                }

                                writer.Write("\n");
                            }
                        }

                        writer.Close();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("File has not been saved.", "Message");
                    return;
                }
            }
            else
            {
                MessageBox.Show("File has not been saved.", "Message");
                return;
            }      
        }

        /*********************************************************************************/
        /*                          button: Hebbian learning                             */
        /*********************************************************************************/
        private void button17_Click(object sender, EventArgs e)
        {
            if (COUNTER_PATTERNS_INPUT == 0)
            {
                MessageBox.Show("Input patterns do not exist.", "Message");
                return;
            }

            hopfield1.M = COUNTER_PATTERNS_INPUT;
            hopfield1.N = SIZE_PATTERN_ROW * SIZE_PATTERN_COLUMN;

            hopfield1.patternsIN = new int[hopfield1.M, hopfield1.N];

            for (int i = 0; i < COUNTER_PATTERNS_INPUT; i++)
            {
                int l = 0;

                for (int j = 0; j < SIZE_PATTERN_ROW; j++)
                    for (int k = 0; k < SIZE_PATTERN_COLUMN; k++)
                    {
                        hopfield1.patternsIN[i, l++] = Pattern1[i].PATTERN_XX[j, k];
                    }
            }

            hopfield1.hebbMethod(hopfield1.patternsIN);
            FLAG_HEB = true;

            button18.Enabled = true;
        }

        /*********************************************************************************/
        /*                          button: Recall entry pattern(s)                      */
        /*********************************************************************************/
        private void button18_Click(object sender, EventArgs e)
        {
            if (COUNTER_PATTERNS_INPUT == 0)
            {
                MessageBox.Show("Input patterns do not exist.", "Message");
                return;
            }
                     
            int[,] temp_pattern = new int[SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN];

            //draw patterns/////////////////////////////////////////////////////////////////////////////////////////////////
            Point point_s = new Point(0, 0);
            Point point_e = new Point(0, 0);
            Point numberPoint = new Point(0, 0);

            if (FLAG_CURRENT_SELECT_INPUT == false)  //none input pattern has been selected 
            {
                ////////////////////CONFIGURE NETWORK/////////////////////////////////
                hopfield1.M = COUNTER_PATTERNS_INPUT;
                hopfield1.N = SIZE_PATTERN_ROW * SIZE_PATTERN_COLUMN;

                hopfield1.patternsIN = new int[hopfield1.M, hopfield1.N];
                hopfield1.patternsOUT = new int[hopfield1.M, hopfield1.N];               

                for (int i = 0; i < COUNTER_PATTERNS_INPUT; i++)
                {
                    int l = 0;

                    for (int j = 0; j < SIZE_PATTERN_ROW; j++)
                        for (int k = 0; k < SIZE_PATTERN_COLUMN; k++)
                        {
                            hopfield1.patternsIN[i, l++] = Pattern1[i].PATTERN_XX[j, k];
                        }
                }
                //////////////////////////////////////////////////////////////////////


                hopfield1.testNetwork(hopfield1.patternsIN, false);   //none input pattern has been selected, flag == false                             
               
                drawPattern3.createScene(pictureBox3);

                index_i_out = 0;
                index_j_out = 0;
                index_k_out = 0;

                COUNTER_PATTERNS_OUTPUT = 0;

                for (int l = 0; l < COUNTER_PATTERNS_INPUT; l++)
                {
                    index_i_out = l;

                    if (index_j_out == MAX_PATTERN_ROW)
                    {
                        index_j_out = 0;
                        index_k_out++;
                    }

                    //calculate start and end pixel
                    point_s.X = index_j_out * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_out * DELTA_X;
                    point_s.Y = index_k_out * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_out * DELTA_Y;

                    point_e.X = (index_j_out + 1) * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_out * DELTA_X;
                    point_e.Y = (index_k_out + 1) * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_out * DELTA_Y;

                    index_j_out++;

                    int k = 0;
                    for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                    {
                        for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                        {
                            temp_pattern[i, j] = hopfield1.patternsOUT[l, k++];
                        }
                    }

                    Pattern2[index_i_out] = new CPattern(point_s, point_e, temp_pattern, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN);

                    drawPattern3.drawPattern(pictureBox3, Pattern2[index_i_out].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, point_s, Color.Green, Color.Green, true, false);

                    COUNTER_PATTERNS_OUTPUT++;

                    //draw number pattern
                    numberPoint.X = point_s.X;
                    numberPoint.Y = point_s.Y - DELTA_TEXT;
                    drawPattern3.drawNumber(pictureBox3, numberPoint, (index_i_out + 1).ToString(), Color.Blue, 0);

                    CURRENT_SELECT_PATTERN_OUTPUT = COUNTER_PATTERNS_OUTPUT - 1;
                }  // for  - nr of input/output patterns
            }      // flag == false (ie. none input pattern has been selected)

            else      // flag == true (ie. one input pattern has been selected)
            {
                ////////////////////CONFIGURE NETWORK/////////////////////////////////
                hopfield1.M = 1;
                hopfield1.N = SIZE_PATTERN_ROW * SIZE_PATTERN_COLUMN;
                
                hopfield1.MAX_ITERATIONS = MAX_ITERATIONS;
                
                hopfield1.patternsIN = new int[hopfield1.M, hopfield1.N];
                hopfield1.patternsOUT = new int[hopfield1.MAX_ITERATIONS, hopfield1.N];                
                
                int n = 0;

                for (int j = 0; j < SIZE_PATTERN_ROW; j++)
                {
                   for (int k = 0; k < SIZE_PATTERN_COLUMN; k++)
                   {
                            hopfield1.patternsIN[0, n++] = Pattern1[CURRENT_SELECT_PATTERN_INPUT].PATTERN_XX[j, k];
                   }
                }
                
                //////////////////////////////////////////////////////////////////////

                hopfield1.testNetwork(hopfield1.patternsIN, true);   // flag == true, one input pattern has been selected
                               
                drawPattern3.createScene(pictureBox3);

                index_i_out = 0;
                index_j_out = 0;
                index_k_out = 0;

                COUNTER_PATTERNS_OUTPUT = 0;

                for (int l = 0; l < hopfield1.ITERATIONS; l++)
                {
                    index_i_out = l;

                    if (index_j_out == MAX_PATTERN_ROW)
                    {
                        index_j_out = 0;
                        index_k_out++;
                    }

                    //calculate start and end pixel
                    point_s.X = index_j_out * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_out * DELTA_X;
                    point_s.Y = index_k_out * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_out * DELTA_Y;

                    point_e.X = (index_j_out + 1) * SIZE_PIXEL * SIZE_PATTERN_ROW + START_X + index_j_out * DELTA_X;
                    point_e.Y = (index_k_out + 1) * SIZE_PIXEL * SIZE_PATTERN_COLUMN + START_Y + index_k_out * DELTA_Y;

                    index_j_out++;

                    int k = 0;
                    for (int i = 0; i < SIZE_PATTERN_ROW; i++)
                    {
                        for (int j = 0; j < SIZE_PATTERN_COLUMN; j++)
                        {
                            temp_pattern[i, j] = hopfield1.patternsOUT[l, k++];
                        }
                    }

                    Pattern2[index_i_out] = new CPattern(point_s, point_e, temp_pattern, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN);

                    drawPattern3.drawPattern(pictureBox3, Pattern2[index_i_out].PATTERN_XX, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL, point_s, Color.Green, Color.Green, true, false);

                    COUNTER_PATTERNS_OUTPUT++;

                    //draw number pattern
                    numberPoint.X = point_s.X;
                    numberPoint.Y = point_s.Y - DELTA_TEXT;
                    drawPattern3.drawNumber(pictureBox3, numberPoint, (index_i_out + 1).ToString(), Color.Blue, 0);

                    CURRENT_SELECT_PATTERN_OUTPUT = COUNTER_PATTERNS_OUTPUT - 1;
                }                
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            point_s.X = 0;
            point_s.Y = 0;
            drawPattern4.createScene(pictureBox4);
            drawPattern4.drawPattern(pictureBox4, CPattern.EMPTY, SIZE_PATTERN_ROW, SIZE_PATTERN_COLUMN, SIZE_PIXEL_SELECT, point_s, Color.Green, Color.Green, true, true);

            pictureBox3.Refresh();
            pictureBox4.Refresh();
            
            textBox8.Clear();

            button9.Enabled = true;
        }

        /*********************************************************************************/
        /*                                button: x                                      */
        /*********************************************************************************/
        private void button10_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { return; }
        }
    }
}

