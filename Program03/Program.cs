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
    }
}
