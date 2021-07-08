using System;

namespace TicTacToe
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe Problem!!!");
            char[] board = gameBoard();
        }
        public static char[] gameBoard()
        {
            char[] board = new char[10];
            for (int i=0; i< board.Length;i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
