namespace _4M05conFurnitureCodeDocumentation
{
    interface ICanSit
    {
        void Sit();
    }
    interface ICanSleep
    {
        void Sleep();
    }
    abstract class Furniture
    {
        abstract public string name { get; protected set; }
        abstract public string color { get; protected set; }
        abstract public override string ToString();
    }
    class Chair : Furniture, ICanSit
    {
        public override string name { get; protected set; }
        public override string color { get; protected set; }
        private int noOfLegs = 0;
        public Chair(string name, string color, int noOfLegs = 4)
        {
            this.name = name;
            this.color = color;
            this.noOfLegs = noOfLegs;
        }
        public void Sit()
        {
            Console.WriteLine("siadam na krześle");
        }
        public override string ToString()
        {
            return $"Krzesło {name}, color: {color}, nóg {noOfLegs}";
        }
    }
    class Bed : Furniture, ICanSleep
    {
        public override string name { get; protected set; }
        public override string color { get; protected set; }
        private int noOfPersons = 1;
        public Bed(string name, string color, int noOfPersons = 1)
        {
            this.name = name;
            this.color = color;
            this.noOfPersons = noOfPersons;
        }
        public void Sleep()
        {
            Console.WriteLine("śpię w łóżku");
        }
        public override string ToString()
        {
            return $"ŁÓŻKO {name}, color: {color}, nóg {noOfPersons}";
        }
    }
    class Couch : Furniture, ICanSit, ICanSleep
    {
        public override string name { get; protected set; }
        public override string color { get; protected set; }
        private int noOfPersons = 1;
        public Couch(string name, string color, int noOfPersons = 1)
        {
            this.name = name;
            this.color = color;
            this.noOfPersons = noOfPersons;
        }
        public void Sleep()
        {
            Console.WriteLine("śpię na wersalce");
        }
        public void Sit()
        {
            Console.WriteLine("siadam na wersalce");
        }
        public override string ToString()
        {
            return $"Wersalka {name}, color: {color}, nóg {noOfPersons}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair chair = new Chair("krzesło szkolne", "białe");

            Chair rockingChair = new Chair("Fotel bujany", "brazowy", 2);
            Chair puf = new Chair("puf", "niebeski", 0);
            Bed bed = new Bed("łózko", "białe");
            Furniture[] funitures = new Furniture[5];
            funitures[0] = chair;
            funitures[1] = rockingChair;
            funitures[2] = puf;
            funitures[3] = bed;
            funitures[4] = new Bed("małżeńskie", "białe", 2);
            foreach (var m in funitures)
                Console.WriteLine(m);
            Console.WriteLine("możesz usiaść na: ");
            foreach (var m in funitures)
                if (m is ICanSit)
                    Console.WriteLine(m.name);
        }
    }
}
