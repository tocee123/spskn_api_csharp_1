namespace AbstractionExplanation.Classes
{
    public class Dog : Mammal
    {
        public int BittenPostmenCount { get; init; }

        private Dog(string name) : base(name)
        {
        }

        public Dog(string name, int bittenPostmenCount) : this(name)
        {
            BittenPostmenCount = bittenPostmenCount;
        }

        public override string GetStats()
            => $"My name is {Name} and I'm a dog! I've bitten already {BittenPostmenCount} postmen";
    }
}
