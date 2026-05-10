using System;

namespace Blocks_Main
{
    public class Square : NamedObject,IShape
    {
        public double Side { get; private set; }

        // :this("kwadrat") -> :base(kwadrat) --- 'this' use constructor of same class, base use constructor of base class
        // int Side -> double Side
        public Square(double Side):base("kwadrat")
        {
            if (Side <= 0) throw new ArgumentException("Give side greater than 0");
            this.Side = Side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public override string ToString()
        {
            return base.ToString() + " o boku " + Side;
        }

        // Add IShape method: CalculatePerimeter()
        public double CalculatePerimeter()
        {
            return Side * 4;
        }
    }
}