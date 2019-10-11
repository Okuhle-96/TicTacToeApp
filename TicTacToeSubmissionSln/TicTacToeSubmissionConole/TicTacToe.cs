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
            _boardRenderer = new TicTacToeConsoleRenderer(20, 6);
            _boardRenderer.Render();

        }
        public int userInput(int row, int column)
        {
            int score;
            score = row * 3 + column;
            return score;
        }

        public void Run()
        {
            char[] sad = new char[9];
            char[] PlayerX = new char[9];
            char[] PlayerO = new char[9];

            for (int plays = 0; plays < 10; plays++)
            {
                if (plays == 0 || plays % 2 != 0)
                {
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();

                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                    sad[userInput(int.Parse(row), int.Parse(column))] = 'X';

                    if (sad[0] == 'X' && sad[1] == 'X' && sad[2] == 'X' || sad[3] == 'X' && sad[4] == 'X' && sad[5] == 'X' ||sad[6] == 'X' && sad[7] == 'X' && sad[8] == 'X')
                    {
                        Console.WriteLine("X has won!!, O takes a loss");
                        return;
                    }

                    if (sad[0] == 'X' && sad[3] == 'X' && sad[6] == 'X' || sad[1] == 'X' && sad[4] == 'X' && sad[7] == 'X' || sad[2] == 'X' && sad[5] == 'X' && sad[8] == 'X')
                    {
                        Console.WriteLine("X has won!!, O takes a loss");
                        return;
                    }

                    if (sad[0] == 'X' && sad[4] == 'X' && sad[8] == 'X' || sad[2] == 'X' && sad[4] == 'X' && sad[6] == 'X')
                    {
                        Console.WriteLine("X has won!!, O takes a loss");
                        return;
                    }
                  
                    if (sad[0] == 'O' && sad[1] == 'O' && sad[2] == 'O' || sad[3] == 'O' && sad[4] == 'O' && sad[5] == 'O' ||  sad[6] == 'O' && sad[7] == 'O' && sad[8] == 'O')
                    {
                        Console.WriteLine("O has won!!, X takes a loss");
                        return;
                    }

                    
                    if (sad[0] == 'O' && sad[3] == 'O' && sad[6] == 'O' || sad[1] == 'O' && sad[4] == 'O' && sad[7] == 'O' ||  sad[2] == 'O' && sad[5] == 'O' && sad[8] == 'O')
                    {
                        Console.WriteLine("O has won!!, X takes a loss");
                        return;
                    }

                    
                    if (sad[0] == 'O' && sad[4] == 'O' && sad[8] == 'O' ||  sad[2] == 'O' && sad[4] == 'O' && sad[6] == 'O')
                    {
                        Console.WriteLine("O has won!!, X takes a loss");
                        return;
                    }


                }

                if (plays % 2 == 0)
                {

                    Console.SetCursorPosition(30, 19);

                    Console.Write("Player O");

                    Console.SetCursorPosition(30, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(30, 22);


                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();

                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O,true);
                    sad[userInput(int.Parse(row), int.Parse(column))] = 'O';

                    if (sad[0] == 'X' && sad[1] == 'X' && sad[2] == 'X' || sad[3] == 'X' && sad[4] == 'X' && sad[5] == 'X' || sad[6] == 'X' && sad[7] == 'X' && sad[8] == 'X')
                    {
                        Console.WriteLine("        Yaaay!!! X Has Won!!");
                        return;
                    }

                    if (sad[0] == 'X' && sad[3] == 'X' && sad[6] == 'X' || sad[1] == 'X' && sad[4] == 'X' && sad[7] == 'X' || sad[2] == 'X' && sad[5] == 'X' && sad[8] == 'X')
                    {
                        Console.WriteLine("        Yaaay!!! X Has Won!!");
                        return;
                    }

                    if (sad[0] == 'X' && sad[4] == 'X' && sad[8] == 'X' || sad[2] == 'X' && sad[4] == 'X' && sad[6] == 'X')
                    {
                        Console.WriteLine("        Yaaay!!! X Has Won!!");
                        return;
                    }

                    if (sad[0] == 'O' && sad[1] == 'O' && sad[2] == 'O' || sad[3] == 'O' && sad[4] == 'O' && sad[5] == 'O' || sad[6] == 'O' && sad[7] == 'O' && sad[8] == 'O')
                    {
                        Console.WriteLine("        Yaaay!!! O Has Won!!");
                        return;
                    }


                    if (sad[0] == 'O' && sad[3] == 'O' && sad[6] == 'O' || sad[1] == 'O' && sad[4] == 'O' && sad[7] == 'O' || sad[2] == 'O' && sad[5] == 'O' && sad[8] == 'O')
                    {
                        Console.WriteLine("        Yaaay!!! O Has Won!!");
                        return;
                    }


                    if (sad[0] == 'O' && sad[4] == 'O' && sad[8] == 'O' || sad[2] == 'O' && sad[4] == 'O' && sad[6] == 'O')
                    {
                        Console.WriteLine("        Yaaay!!! O Has Won!!");
                        return;
                    }

                }
            }
        }
    }
}
