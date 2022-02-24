//----------------------------------------------------------------------------------//
//                                                                                  //
//  File name:                  CHopfield.cs                                        //
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

namespace Hopfield
{

    //--------------------------------------------------------------------------//
    //                                                                          //
    //                          Class CNeuron()                                 //
    //                                                                          //
    //--------------------------------------------------------------------------//
    class CNeuron
    {
        public int U; // the output value of the weights sum
        public int Y; // the output value of the activation function                     

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      activateFunction()                                  //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int u_t - the sum of all weights                    //
        //                      int x_t - before response                           //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to calculate a neuron response                  //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void activationFunction(int u_t, int x_t)
        {
            if (u_t > 0)   
            {
                Y = 1;            
            }
            
            if (u_t == 0)
            {
               if (x_t > 0) 
                  Y = 1;
               else 
                  Y = -1;       //  Y = x_t;      or   Y = 0;  
            }
            
            if (u_t < 0)
            {
                Y = -1;     
            }        
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      weightSum()                                         //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int [,]X - bipolar or binary patterns array                   //
        //                      int[,] W - before response                          //
        //                      int theta - threshold value                         //
        //               we may assign a different threshold value for every neuron //                      
        //                      int N - dimension of the square array with weights  //
        //                      int m - number of patterns                          //
        //                      int i - number of the neuron                        //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to calculate sum of input weights               //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void weightSum(int [,]X, int [,]W, int theta, int N, int m, int i)
        {
            U = X[m, i];    // very important step

            for (int j = 0; j < N; j++)
                U += W[i, j] * X[m, j];   

            U += theta;
        }
    }

    //--------------------------------------------------------------------------//
    //                                                                          //
    //                          Class CHopfield()                               //
    //                                                                          //
    //--------------------------------------------------------------------------//
    class CHopfield
    {        
        public int N;       // number of all neurons in a net
        public int M;       // number of input patterns to store in a net
        public int[,] W;    // square array with weights     
       
        public int MAX_ITERATIONS;
        public int ITERATIONS;

        public int[,] patternsIN;  // array with input patterns
        public int[,] patternsOUT; // array with output patterns
        public int[,] temp;        // array with temporary patterns
        
        bool fHebb;

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              CHopfield()                                                 //
        //              [Constructor - 1]                                           //
        //                                                                          //
        //              Describe:                                                   //
        //                 Create a new Hopfield network object                     //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public CHopfield()
        {
            fHebb = false;
            ITERATIONS = 0;
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      hebbMethod()                                        //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] patterns - patterns array                    //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to calculate weights values using Hebb method   //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void hebbMethod(int[,] patterns)
        {
            W = new int [N, N];   //   W, U, and theta could be of type double

          binToBipolar(patterns, M, N);

     for (int i = 0; i < N; i++)
           {
            for (int j = 0; j <= i; j++)
              {
                W[i, j] = 0;
                if (j < i)
                {
                   for (int m = 0; m < M; m++)
                      { 
                       W[i, j] += patterns[m, i] * patterns[m, j];
                      }
                 }
                W[j, i] = W[i, j];
              }
           }

           fHebb = true;
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      binToBipolar()                                      //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] patterns                                     //
        //                      int M - number of patterns                          //
        //                      int N - number of pixels in a pattern               //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to convert binary patterns to bipolar patterns  //
        //                                                                          //
        //--------------------------------------------------------------------------//
        protected void binToBipolar(int[,] patterns,int M, int N)
        {
            for (int m = 0; m < M; m++)
                for (int i = 0; i < N; i++)
                {
                    if (patterns[m, i] == 0)
                        patterns[m, i] = -1;
                    else
                        patterns[m, i] = 1;
                }
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      bipolarToBin()                                      //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] patterns                                     //
        //                      int M - number of patterns                          //
        //                      int N - number of pixels in a pattern               //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function to convert bipolar patterns to binary patterns  //
        //                                                                          //
        //--------------------------------------------------------------------------//
        protected void bipolarToBin(int[,] patterns, int M, int N)
        {
            for (int m = 0; m < M; m++)
                for (int i = 0; i < N; i++)
                {
                    if (patterns[m, i] == -1)
                        patterns[m, i] = 0; 
                    else                    
                        patterns[m, i] = 1; 
                }
        }

        //--------------------------------------------------------------------------//
        //                                                                          //
        //              Function name:                                              //
        //                      bipolarToBin()                                      //
        //                                                                          //
        //              Input parameters:                                           //
        //                      int[,] patterns - input patterns                    //
        //                      bool flag - set iterations (true) /                 //
        //                                  no - set iterations(false)              //
        //                                                                          //
        //                                                                          //
        //              Return value (void):                                        //
        //                                                                          //
        //              Describe:                                                   //
        //                 Function tests input patterns entered to a Hopfield net  //
        //                                                                          //
        //--------------------------------------------------------------------------//
        public void testNetwork(int[,] patterns, bool flag)
        {
            bool f;
            int counter = 0;
            int delta = 0;
            
            temp = new int[10000, N];            

            if (fHebb == false)
                return;
            
            int [,]X = new int [M, N];
            
            CNeuron[] cells = new CNeuron[N];

            for (int i = 0; i < N; i++)
                cells[i] = new CNeuron();
            
            binToBipolar(patterns, M, N);

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    X[i, j] = patterns[i, j];

            if (flag == true)             // flag == true - it means that recalling one selected pattern: patterns[0, j]
            {
                for (int i = 0; i < 10000; i++)
                    for (int j = 0; j < N; j++)                                                
                      temp[i, j] = patterns[0, j];
            }
                 
          //  int ifChanged = 0;   // extra flag
     
            for (int m = 0; m < M; m++)
            {      
               // ifChanged = 0;        
                while(true)   // make some iterations with recalling
                {   
                    f = false;
                                      
                    for (int i = 0; i < N; i++)
                    {                        
                        cells[i].weightSum(X, W, 0, N, m, i);  //cells[i].weightSum(X, W, X[m, i], N, m, i);
                        cells[i].activationFunction(cells[i].U, X[m, i]);

                        if (X[m, i] != cells[i].Y)
                        {                             
                            X[m, i] = cells[i].Y;
                            f = true;    // some changes have occured
                          //  ifChanged++;
                        
                          //  if (ifChanged >= 1)   // skip presenting the first changed neuron 
                            // {
                            //  if (flag == true)   // i.e. recalling one pattern selected from the input eg. noisy one 
                           //    {                              
                           //     for (int j = 0; j < N; j++)
                           //         temp[counter, j] = X[m, j];
                           //     counter++;    
                           //    } 
                           //  }  // if (ifChanged ...                                                                                                                 
                        }   // if  !=                                                                           
                    }  // for i
                  
                    if (flag == true)   // i.e. recalling one pattern selected from the input eg. noisy one 
                        {                              
                          for (int j = 0; j < N; j++)
                              temp[counter, j] = X[m, j];
                              counter++;    
                        } 
                    if (f == false)  // one or none change has occured during the recalling process
                    {
                      break;   // break from while (true) loop
                    }  

                } // while                                          
            }    // for (m

            if (flag == true)  // flag == true - it means that recalling one selected pattern 
            {               
                int i = 0;

                if (counter > 10)
                {
                    bipolarToBin(temp, counter, N);

                delta = counter / 10;   // delta = counter / MAX_ITERATIONS

                for (int m = 0; m < counter && i < MAX_ITERATIONS; m += delta)                     
                    {
                        for (int j = 0; j < N; j++)
                            patternsOUT[i, j] = temp[m, j];

                        i++;
                    }

                    ITERATIONS = i;

                    //last results
                    for (int j = 0; j < N; j++)
                      patternsOUT[i - 1, j] = temp[counter - 1, j];                   

                }
                else    // counter < 10   and  flag == true - it means that recalling one selected pattern 
                {                                  
                    if (counter > 0)
                    {
                        bipolarToBin(temp, counter, N);

                        for (int m = 0; m < counter && i < MAX_ITERATIONS; m += 1)  
                        {
                            for (int j = 0; j < N; j++)
                                patternsOUT[i, j] = temp[m, j];

                            i++;
                        }     
                        
                        ITERATIONS = i;

                        //last results
                         for (int j = 0; j < N; j++)
                             patternsOUT[i - 1, j] = temp[counter - 1, j];
                    }
                    else  // counter == 0
                    {
                        for (int j = 0; j < N; j++)      //!!! I added this 
                            temp[0, j] = X[0, j];
                                       
                        bipolarToBin(temp, 1, N);  
                        
                        ITERATIONS = 1;

                       for (int j = 0; j < N; j++)
                         patternsOUT[0, j] = temp[0, j];
                    } // if
                }     // else                          
            }    //  if  if (flag == true)
            else    // if (flag == false)
            {
                bipolarToBin(X, M, N);

                for (int i = 0; i < M; i++)
                    for (int j = 0; j < N; j++)
                        patternsOUT[i, j] = X[i, j];   
            }
        }
    }
}