using System;

namespace Blocks_Main
{
    // triangle -> Triangle
    public class Triangle : NamedObject, IShape
    {
        public double A {  get; set; } //Zmienne zawierające długości boków
        public double B { get; set; }
        public double C { get; set; }

        public Triangle (double A, double B, double C):base("trójkąt")
        {
            if (A <= 0 || B <= 0 || C <= 0) throw new ArgumentException("Give positive sides");
            if (A + B <= C || A + C <= B || B + C <= A) throw new ArgumentException("This is not a triangle");

            this.A = A;
            this.B = B;
            // C -> this.C
            this.C = C;
        }

        // Pole trójkąta jest liczone wzorem Herona
        // https://pl.wikipedia.org/wiki/Wz%C3%B3r_Herona

        // Removed override (interface methods don't require overriding)
        public double CalculateArea()
        {
            double p = this.CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double CalculatePerimeter()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return base.ToString() + $" o bokach {A},{B},{C}";
        }
    }
}