namespace AbstractionExplanation.Classes
{
    public class Mouse : Mammal
    {
        public double EatenCheeseInKg { get; init; }
        private Mouse(string name) : base(name)
        { 
        }

        public Mouse(string name, double eatenCheeseInKg): this(name)
        {
            EatenCheeseInKg = eatenCheeseInKg;
        }
    }
}
