namespace Blocks_Main
{
    public class triangle : NamedObject, IShape
    {
        public double A {  get; set; } //Zmienne zawierające długości boków
        public double B { get; set; }
        public double C { get; set; }

        public Triangle (double a, double b,double c):base("trójkąt")
        {
            this.A = A;
            this.B = B;
            C = C;
        }

        // Pole trójkąta jest liczone wzorem Herona
        // https://pl.wikipedia.org/wiki/Wz%C3%B3r_Herona

        public override double CalculateArea()
        {
            double p = this.CalculatePerimeter() / 2;
            return System.Math.Sqrt(p * (p - A) * (p - B) * (p - C));
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