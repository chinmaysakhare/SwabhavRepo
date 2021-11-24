using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[] tictactoeArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice; 
        static int exitCondition = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Player1 is 'X' and Player2 is 'O'");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                DisplayBoard();
                choice = int.Parse(Console.ReadLine());
                if (tictactoeArray[choice] != 'X' && tictactoeArray[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        tictactoeArray[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        tictactoeArray[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, tictactoeArray[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                exitCondition = CheckForWin();
            } while (exitCondition != 1 && exitCondition != -1);
            DisplayBoard();
            if (exitCondition == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else 
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void DisplayBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tictactoeArray[1], tictactoeArray[2], tictactoeArray[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tictactoeArray[4], tictactoeArray[5], tictactoeArray[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tictactoeArray[7], tictactoeArray[8], tictactoeArray[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckForWin()
        {
            if (tictactoeArray[1] == tictactoeArray[2] && tictactoeArray[2] == tictactoeArray[3])
            {
                return 1;
            } 
            else if (tictactoeArray[4] == tictactoeArray[5] && tictactoeArray[5] == tictactoeArray[6])
            {
                return 1;
            }
            else if (tictactoeArray[6] == tictactoeArray[7] && tictactoeArray[7] == tictactoeArray[8])
            {
                return 1;
            }    
            else if (tictactoeArray[1] == tictactoeArray[4] && tictactoeArray[4] == tictactoeArray[7])
            {
                return 1;
            }  
            else if (tictactoeArray[2] == tictactoeArray[5] && tictactoeArray[5] == tictactoeArray[8])
            {
                return 1;
            }
            else if (tictactoeArray[3] == tictactoeArray[6] && tictactoeArray[6] == tictactoeArray[9])
            {
                return 1;
            }
            else if (tictactoeArray[1] == tictactoeArray[5] && tictactoeArray[5] == tictactoeArray[9])
            {
                return 1;

            }
            else if (tictactoeArray[3] == tictactoeArray[5] && tictactoeArray[5] == tictactoeArray[7])
            {
                return 1;
            }
            else if (tictactoeArray[1] != '1' && tictactoeArray[2] != '2' && tictactoeArray[3] != '3' && tictactoeArray[4] != '4' && tictactoeArray[5] != '5' && tictactoeArray[6] != '6' && tictactoeArray[7] != '7' && tictactoeArray[8] != '8' && tictactoeArray[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

