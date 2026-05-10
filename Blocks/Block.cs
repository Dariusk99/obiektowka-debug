namespace Blocks_Main
{
    public class Block:IBlock
    {
        public static string evaluateSize(Block b)
        {
            if (b.calculateVolume() > 200)
                return "Bloczek jest duży";
            else if (b.calculateVolume() > 100)
                return "Bloczek jest średni";
            else
                return "Bloczek jest mały";
        }

        public int Height { get; private set;}
        public IShape BaseShape { get; private set; }

        public Block(int Height, IShape b) 
        {
            this.Height = Height;
            BaseShape = b;
        }
        public double calculateVolume()
        {
            return Height * BaseShape.CalculateArea();
        }

        public override string ToString()
        {
            return $"Bloczek o podstawie {BaseShape.ToString()} i wysokości {Height} ";
        }

        
    }
}