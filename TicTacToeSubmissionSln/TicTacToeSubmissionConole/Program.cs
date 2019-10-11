using System;

namespace TicTacToeSubmissionConole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.SetCursorPosition(10,2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELKOME TO MORTAL Tic Tac KOMBAT");

                Console.SetCursorPosition(1, 4);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("COLUMN: |     |     |     |");

            Console.SetCursorPosition(1, 5);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("________|  0  |  1  |  2  |");

                Console.SetCursorPosition(1, 6);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("        |");

            Console.SetCursorPosition(1, 7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ROW:  0 |");

                Console.SetCursorPosition(1, 8);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("________|");

            Console.SetCursorPosition(1, 9);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("        |");

                Console.SetCursorPosition(1, 10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("ROW:  1 |");

            Console.SetCursorPosition(1, 11);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("________|");

                Console.SetCursorPosition(1, 12);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("        |");

            Console.SetCursorPosition(1, 13);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ROW:  2 |");

                Console.SetCursorPosition(1, 14);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("________|");




            var ticTacToe = new TicTacToe();

            ticTacToe.PlayerOneTurn1();

            ticTacToe.PlayerTwoTurn1();

            ticTacToe.PlayerOneTurn2();

            ticTacToe.PlayerTwoTurn2();

            
            Console.ForegroundColor = oldColor ;


            Console.SetCursorPosition(20, 31);
            Console.WriteLine("MORTAL TIC TAC KOMBAT TOURNAMENT HAS ENDED");
            Console.ReadLine();
        }
    }
}
