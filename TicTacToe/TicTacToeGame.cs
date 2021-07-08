using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public static char GetPersonInput()
        {
            char person;
            Console.WriteLine("Enter Your choice X or O");
            person = Convert.ToChar(Console.ReadLine());
            return person;
        }
        public static char GetComputerInput(char person)
        {
            char computer;
            if (person == 'x' || person == 'X')
                computer = 'O';
            else
            {
                computer = 'X';
            }
            return computer;
        }
    }
}
