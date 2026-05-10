using System;

namespace Blocks_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Block[] blocks= new Block[12];

            for (int i = 0; i < 12; i++) 
            {
                int b = rand.Next(1, 10);
                switch (i % 3)
                {
                    case 0:
                        blocks[i] = new Block(b, Square(b));
                        break;
                    case 1:
                        blocks[i] = new Block(b, new Circle(b));
                    case 2:
                        blocks[i] = new Block(b, new EquilateralTriangle(b));
                        break;
                }
                
                
                Console.WriteLine(blocks[i].ToString()); ;
                Console.WriteLine(blocks[i].evaluateSize(blocks[i]));
            }
        }
    }
}
