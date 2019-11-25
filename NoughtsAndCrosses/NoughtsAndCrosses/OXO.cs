using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    class OXO
    {
        public enum Piece { Nought, Cross, Space };

        public Piece[,] game = new Piece[3, 3];
        public static void GenerateGrid()
        {
            Console.WriteLine("   |   |   ");            
            Console.WriteLine("------------");           
            Console.WriteLine("   |   |   ");            
            Console.WriteLine("------------");            
            Console.WriteLine("   |   |   ");
            Console.WriteLine("");
        }
    }
}
