using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe Problem!!!");
            GameBoard game = new GameBoard();
            game.Board();
        }
    }
}
