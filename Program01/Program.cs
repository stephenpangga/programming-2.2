using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            //int[,] matrix = new int[8,8];
            int[,] matrix = new int[11,11];
            //InitMatrix2D(matrix);
            InitMatrixLinear(matrix);
            DisplayMatrix(matrix);
            //this will have the cross
            Console.WriteLine();
            Console.WriteLine("This matrix has a cross");
            DisplayMatrixWithCross(matrix);

        }

        void InitMatrix2D(int[,] matrix)
        {
            //filling in the matrix with number.
            int numbers = 1;
            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers;
                    numbers++;
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        void InitMatrixLinear(int[,] matrix)
        {
            //NEED TO USE MATHS HERE. I THINK
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int newmatrix = row * col;

            for(int i =0; i<newmatrix; i++)
            {
                matrix[i/col, i%col] = i + 1;
            }
            //understand what modulo is.
        }
            
        void DisplayMatrixWithCross(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {  
                    //if row and column is equal change color
                    if(i==j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    //if the column value is equal to the row mirrored value change BG color to yellow
                    else if(j==matrix.GetLength(1)-(i+1)/*matrix.GetLength(1)*/)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write("{0,4}", matrix[i,j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
