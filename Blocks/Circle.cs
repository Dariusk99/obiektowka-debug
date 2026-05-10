namespace Blocks_Main
{
    public class Circle:NamedObject,IShape
    {
        public double Radius { get; private set;}

        public Circle(double r):base("koło")
        {
            Radius = r;
        }

        public double CalculateArea()
        {
            return Radius * Radius * System.Math.PI;
        }

        public override string ToString()
        {
            return base.ToString()+" o promieniu "+Radius.ToString();
        }


        public double CalculatePerimeter()
        {
            return 2*System.Math.PI*Radius;
        }
    }
}
