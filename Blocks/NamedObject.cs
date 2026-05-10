namespace Blocks_Main
{
    public abstract class NamedObject
    {

        public string Name { get; private set; }

        public NamedObject():this("Obiekt")
        {
        }

        public NamedObject (string Name)
        {
            this.Name = Name;
        }

        // int -> string
        public override string ToString()
        {
            return Name;
        }

    }
}