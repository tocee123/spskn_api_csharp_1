namespace AbstractionExplanation.Classes
{
    public class Cat : Mammal
    {
        public int CoughtMiceCount { get; init; }
        private Cat(string name) : base(name)
        {
        }

        public Cat(string name, int coughtMiceCount) : this(name)
        {
            CoughtMiceCount = coughtMiceCount;
        }

        public override string GetStats()
            => $"My name is {Name} and I'm a cat! I've bitten eaten {CoughtMiceCount} mice";
    }
}
