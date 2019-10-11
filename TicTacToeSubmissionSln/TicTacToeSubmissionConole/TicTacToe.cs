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

        public string[]pos = new string[9] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

        
        public void CharacterOne()
        {
            Console.SetCursorPosition(28, 19);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("VS");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, 19);
            Console.Write("SCORPION IS \"X\"");
                                                            
            Console.SetCursorPosition(2, 20);

            Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();

            Console.Write("ENTER \"ROW\" NUMBER: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);
            
                Console.WriteLine();

            Console.Write("ENTER \"COLUMN\" NUMBER: ");
            var column = Console.ReadLine();

            


            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

            
        }

        public void CharacterTwo()
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(42, 19);
            Console.Write("SUB-ZERO IS \"O\"");
            Console.ForegroundColor = ConsoleColor.White;

            
                Console.WriteLine();

            Console.SetCursorPosition(40, 21);
            Console.Write("ENTER \"ROW\" NUMBER: ");
            var row = Console.ReadLine();

                Console.WriteLine();

            Console.SetCursorPosition(40, 23);
            Console.Write("ENTER \"COLUMN\" NUMBER: ");
            var column = Console.ReadLine();

                Console.WriteLine();


            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

        }
       

        public bool CheckWinCoordinates()
        {
            if (pos[0] == "O" && pos[1] == "O" && pos[2] == "O") // ROW 0
            {
                return true;
            }
            else if (pos[3] == "O" && pos[4] == "O" && pos[5] == "O") // ROW 1
            {
                return true;
            }
            else if (pos[6] == "O" && pos[7] == "O" && pos[8] == "O") // ROW 2
            {
                return true;
            }

            else if (pos[0] == "O" && pos[4] == "O" && pos[8] == "O") // ACCROSS 0 = 0,0 - 4 = 1,1 - 8 = 2,2 
            {
                return true;
            }
            else if (pos[6] == "O" && pos[4] == "O" && pos[2] == "O") // ACCROSS 6 = 2,0 - 4 = 1,1 - 2 = 0,1 
            {
                return true;
            }

            else if (pos[0] == "O" && pos[3] == "O" && pos[6] == "O") // COLUMN 0
            {
                return true;
            }
            else if (pos[1] == "O" && pos[4] == "O" && pos[7] == "O") // COLUMN 1 
            {
                return true;
            }
            else if (pos[2] == "O" && pos[5] == "O" && pos[8] == "O") // COLUMN 2
            {
                return true;
            }

            if (pos[0] == "X" && pos[1] == "X" && pos[2] == "X") // ROW 0
            {
                return true;
            }
            else if (pos[3] == "X" && pos[4] == "X" && pos[5] == "X") // ROW 1
            {
                return true;
            }
            else if (pos[6] == "X" && pos[7] == "X" && pos[8] == "X") // ROW 2 
            {
                return true;
            }

            else if (pos[0] == "X" && pos[4] == "X" && pos[8] == "X") // ACCROSS 0 = 0,0 - 4 = 1,1 - 8 = 2,2 
            {
                return true;
            }
            else if (pos[6] == "X" && pos[4] == "X" && pos[2] == "X") // ACCROSS 6 = 2,0 - 4 = 1,1 - 2 = 0,1
            {
                return true;
            }

            else if (pos[0] == "X" && pos[3] == "X" && pos[6] == "X") // COLUMN 0
            {
                return true;
            }
            else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") // COLUMN 1
            {
                return true;
            }
            else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X") // COLUMN 2
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
