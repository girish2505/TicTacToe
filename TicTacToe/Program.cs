using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe Problem!!!");
            char[] board = gameBoard();
            char person = TicTacToeGame.GetPersonInput();
            char computer = TicTacToeGame.GetComputerInput(person);
            Console.WriteLine("User has chosen {0} and computer has chosen {1}", person, computer);
        }
        public static char[] gameBoard()
        {
            char[] board = new char[10];
            for (int i=0; i< board.Length;i++)
            {
                board[i] = ' ';
            }
                Console.WriteLine("   |    |  ");
                Console.WriteLine(" {0} | {1}  |{2} ", board[1], board[2], board[3]);
                Console.WriteLine("___|____|___");
                Console.WriteLine("   |    |  ");
                Console.WriteLine(" {0} | {1}  |{2} ", board[4], board[5], board[6]);
                Console.WriteLine("___|____|___");
                Console.WriteLine("   |    |  ");
                Console.WriteLine(" {0} | {1}  |{2} ", board[7], board[8], board[9]);
                Console.WriteLine("   |    |  ");
            return board;
        }
    }
}
