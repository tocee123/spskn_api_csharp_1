namespace AbstractionExplanation.Classes
{
    public abstract class Mammal : IAnimal
    {
        public string Name { get; init; }

        protected Mammal(string name)
        {
            Name = name;
        }

        public virtual string GetStats()
            => $"Basic {GetType().Name} status";
    }
}
