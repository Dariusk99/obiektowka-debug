//Changed <ImplicitUsings>true</ImplicitUsings> to false for clean code and delete System. near methods
using System;

namespace Blocks_Main
{
    public class Circle:NamedObject,IShape
    {
        public double Radius { get; private set;}

        public Circle(double Radius):base("koło")
        {
            if (Radius <= 0) 
                throw new ArgumentException("Give positive radius greater than 0");

            this.Radius = Radius;
        }

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override string ToString()
        {
            return base.ToString() + " o promieniu " + Radius.ToString();
        }


        public double CalculatePerimeter()
        {
            return 2 * Math.PI*Radius;
        }
    }
}
