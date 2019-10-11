using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();

            
        }


        public void PlayerOneTurn1()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(2, 19);

            Console.Write("SCORPION IS \"X\"");
                                                            
            Console.SetCursorPosition(2, 20);

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();

            Console.Write("ENTER ROW NUMBER: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);
            
            Console.WriteLine();

            Console.Write("ENTER COLUMN NUMBER: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

            
        }

        public void PlayerTwoTurn1()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(2, 25);

            Console.Write("SUB-ZERO IS \"O\"");

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(2, 26);

            Console.WriteLine();

            Console.Write("ENTER ROW NUMBER: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 28);

            Console.WriteLine();

            Console.Write("ENTER COLUMN NUMBER: ");
            var column = Console.ReadLine();


            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

           

        }

        public void PlayerOneTurn2()
        {

            
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(2, 19);

            Console.Write("SCORPION IS \"X\"");

            Console.SetCursorPosition(2, 20);

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();

            Console.Write("ENTER ROW NUMBER: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);

            Console.WriteLine();

            Console.Write("ENTER COLUMN NUMBER: ");
            var column = Console.ReadLine();


            
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);


        }

        public void PlayerTwoTurn2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(2, 25);

            Console.Write("SUB-ZERO IS \"O\"");

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(2, 26);

            Console.WriteLine();

            Console.Write("ENTER ROW NUMBER: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 28);

            Console.WriteLine();

            Console.Write("ENTER COLUMN NUMBER: ");
            var column = Console.ReadLine();


            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);



        }

    }
}
