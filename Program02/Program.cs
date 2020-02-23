using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program02
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
            //the build of the matrix
            int[,] matrix = new int[10, 8];
            InitMatrixRandom(matrix, 1, 100);
            DisplayMatrix(matrix);

            //ask for the number
            Console.Write("Enter a Number (to search for): ");
            int number = int.Parse(Console.ReadLine());

            Position pos = new Position();
            pos = SearchNumber(matrix, number);

            Console.WriteLine($"The Number {number} is found first at position [{pos.row + 1},{pos.col + 1}]");

            //this is for checking backwards
            Position posB = new Position();
            posB = SearchNumberBackwards(matrix, number);

            Console.WriteLine($"The Number {number} is found last at position [{posB.row + 1},{posB.col + 1}]");


        }
        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(min, max);
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        Position SearchNumber(int[,] matrix, int number)
        {
            Position position = new Position();
            //a true or false detector. so return true when the number is found.
            //bool found = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == number)//if the number is found
                    {
                        position.row = i;
                        position.col = j;
                        //found = true;
                        return position;
                    }
                }
            }
            return position;

        }

        Position SearchNumberBackwards(int[,]matrix, int number)
        {
            Position pos = new Position();
            //bool found = false;
            //-- to check backwards?
            for (int i = 0; i < matrix.GetLength(0); i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j--)
                {
                    if (matrix[i, j] == number)//if the number is found
                    {
                        pos.row = i;
                        pos.col = j;
                        //found = true;
                        return pos;
                    }
                }
            }
            return pos;
        }
    }
}
