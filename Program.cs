using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the pattern of a chess board that is 8 x 8. Use X and O to represent the squares.
        
            //create  the 8x8 pattern
            for (int column = 0; column < 8; column++) // 8 columns
            {
                for (int row = 0; row < 8; row++) // 8 rows
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((row + column) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
