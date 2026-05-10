namespace Blocks_Main
{
    public abstract class NamedObject
    {

        public string Name { get; private set; }

        public NamedObject():this("Obiekt")
        {
        }

        public NamedObject (string name)
        {
            Name = name;
        }

        public override int ToString()
        {
            return Name;
        }

    }
}