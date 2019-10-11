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
            Console.WriteLine("WELKOME TO MORTAL KOMBAT \"T1C T4C T03\" ");

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


            ticTacToe.CharacterOne();

            ticTacToe.CharacterTwo();

            ticTacToe.CharacterOne();

            ticTacToe.CharacterTwo();

            ticTacToe.CharacterOne();

            ticTacToe.CharacterTwo();

            ticTacToe.CharacterOne();

            ticTacToe.CharacterTwo();

            ticTacToe.CharacterOne();


           
            ticTacToe.CheckWinCoordinates();



            Console.ForegroundColor = oldColor ;


            Console.SetCursorPosition(20, 30);
            Console.WriteLine("MORTAL KOMBAT \"T1C T4C TO3\" TOURNAMENT HAS ENDED");
            Console.ReadLine();
        }

    }
}
