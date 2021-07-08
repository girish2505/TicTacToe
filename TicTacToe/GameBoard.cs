using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class GameBoard
    {
        //by default i am providing size of 10 where no use of Zero.....
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void Board()
        {
            Console.WriteLine("   |    |  ");
            Console.WriteLine(" {0} | {1}  |{2} ",arr[1],arr[2],arr[3]);
            Console.WriteLine("   |    |  ");
            Console.WriteLine(" {0} | {1}  |{2} ", arr[4], arr[5], arr[6]);
            Console.WriteLine("   |    |  ");
            Console.WriteLine(" {0} | {1}  |{2} ", arr[7], arr[8], arr[9]);
            Console.WriteLine("   |    |  ");
        }
    }
}
