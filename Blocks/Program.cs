using System;

namespace Blocks_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Block[] blocks = new Block[12];

            for (int i = 0; i < 12; i++) 
            {
                // int b -> double b
                double b = rand.Next(1, 10);
                switch (i % 3)
                {
                    case 0:
                        // add 'new' near Square. Square is class not method. Class need word new while creating constructor
                        blocks[i] = new Block(b, new Square(b));
                        break;
                    case 1:
                        blocks[i] = new Block(b, new Circle(b));
                        // add break statement
                        break;
                    case 2:
                        blocks[i] = new Block(b, new EquilateralTriangle(b));
                        break;
                }
                
                // Console.WriteLine on object automatically call ToString if class have this method so ToString() is useless
                Console.WriteLine(blocks[i]);
                // evaluateSize is static method so we call it by calling Class.method()
                Console.WriteLine(Block.EvaluateSize(blocks[i]));
            }
        }
    }
}
