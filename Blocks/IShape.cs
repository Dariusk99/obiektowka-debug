namespace Blocks_Main
{
    public interface IShape
    {
        // Remove field perimeter - interfaces cannot have fields
        public double CalculateArea();
        public double CalculatePerimeter();

    }
}