namespace Blocks_Main
{
    public class Square :NamedObject,IShape
    {
        public double Side { get; private set; }

        public Square(int v):this("kwadrat")
        {
            this.Side = v;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public override string ToString()
        {
            return base.ToString() + " o boku " + Side.ToString();
        }
    }
}