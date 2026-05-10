using System;

namespace Blocks_Main
{
    public class Block:IBlock
    {
        // PascalCase evaluate -> Evaluate
        public static string EvaluateSize(Block b)
        {
            // redundant method call. returned value stored in variable
            double volume = b.CalculateVolume();

            if (volume > 200)
                return "Bloczek jest duży";
            else if (volume > 100)
                return "Bloczek jest średni";
            else
                return "Bloczek jest mały";
        }

        public double Height { get; private set; }
        public IShape BaseShape { get; private set; }

        //int -> double Height
        public Block(double Height, IShape BaseShape) 
        {
            if (Height <= 0) throw new ArgumentException("Give positive height grater than 0");
            if (BaseShape == null) throw new ArgumentNullException("Base shape is null");

            this.Height = Height;
            this.BaseShape = BaseShape;
        }
        
        public double CalculateVolume()
        {
            return Height * BaseShape.CalculateArea();
        }

        public override string ToString()
        {
            return $"Bloczek o podstawie {BaseShape.ToString()} i wysokości {Height} ";
        }
    }
}