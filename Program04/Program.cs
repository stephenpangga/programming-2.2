using System;

namespace Program04
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
            int[,] chessboard = new int[8, 8];
            InitChessboard(chessboard);
            PositionKnight(chessboard);
            DisplayChessboard(chessboard);

        }

        void InitChessboard(int[,]chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = 0;
                }
            }
        }

        void DisplayChessboard(int[,] chessboard)
        {
            string piece = "";
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if(chessboard[row, col] == 0)
                    {
                        Console.ResetColor();
                        piece = ".";
                        //Console.Write(".");
                    }
                    else if(chessboard[row, col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        piece = "*";
                        //Console.Write("*");
                    }
                    else if(chessboard[row,col] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        piece = "*";
                        //Console.Write("*");
                    }
                    Console.Write("{0,3} ", piece);
                }
                Console.WriteLine();
            }
        }

        void PositionKnight(int[,] chessboard)
        {
            Random rnd = new Random();
            //row
            int randomR = rnd.Next(0, chessboard.GetLength(0));
            //column
            int randomC = rnd.Next(0, chessboard.GetLength(1));

            Position position = new Position();
            position.row = randomR;
            position.column = randomC;

            chessboard[randomR, randomC] = 1;

            //return chessboard;
        }

        void PossibleKnightMoves(int[,] chessboard, Position position)
        {

        }
    }
}
