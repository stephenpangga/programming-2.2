using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
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
            RegularCandies[,] playingField = new RegularCandies[9,9];
            InitCandies(playingField);
            DisplayCandies(playingField);
            bool scorerow = ScoreRowPresent(playingField);
            bool scorecolumn = ScoreColumnPresent(playingField);

            //this for the score row
            if(scorerow)
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }

            //message when there is a score in the column
            if(scorecolumn)
            {
                Console.WriteLine("column score");
            }
            else
            {
                Console.WriteLine("no column  score");
            }

        }

        void InitCandies(RegularCandies[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (RegularCandies)rnd.Next(1,7);
                }
            }
        }

        void DisplayCandies(RegularCandies[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //Console.WriteLine(matrix[i,j]);
                    if(matrix[i,j]==RegularCandies.JellyBean)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if(matrix[i, j] == RegularCandies.Lozenge)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if(matrix[i, j] == RegularCandies.LemonDrop)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if(matrix[i, j] == RegularCandies.Gum_Square)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if(matrix[i,j] == RegularCandies.LollipopHead)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if(matrix[i, j] == RegularCandies.Jujube_Cluster)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write(" #");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        //still need to do question e and f
        bool ScoreRowPresent(RegularCandies[,] matrix)
        {
            //this will be use as a counter.
            int count = 1;
            //the current candy
            RegularCandies currentCandy = RegularCandies.JellyBean;

            for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i+j !=0)
                    {
                        //if the candy is the same as in the matrix add 1 to counter
                        if (currentCandy == matrix[i, j])
                        {
                            count++;
                        }
                        else if (count >= 3)
                        {
                            //to check if the counter reaches 3;
                            return true;
                        }
                        else
                        {
                            //if its the same candies, set the counter to 1;
                            count = 1;
                        }
                        
                    }                    
                    //set a new current candy
                    currentCandy = matrix[i, j];

                }
            }
            return false;
            /*
            if (count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }

        bool ScoreColumnPresent(RegularCandies[,] matrix)
        {
            //this will be use as a counter.
            int count = 1;
            //the current candy
            RegularCandies currentCandy = RegularCandies.JellyBean;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (row + col != 0)
                    {
                        //if the candy is the same as in the matrix add 1 to counter
                        if (currentCandy == matrix[row, col])
                        {
                            count++;
                        }
                        else if (count >= 3)
                        {
                            //to check if the counter reaches 3;
                            return true;
                        }
                        else
                        {
                            //if its the same candies, set the counter to 1;
                            count = 1;
                        }

                    }
                    //set a new current candy
                    currentCandy = matrix[row, col];
                }
            }
            return false;
        }
    }
}
