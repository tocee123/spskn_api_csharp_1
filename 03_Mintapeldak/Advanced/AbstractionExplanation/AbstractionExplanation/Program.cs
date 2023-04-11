using AbstractionExplanation.Classes;

var animals = new List<IAnimal> { new Cat("Tom", 12), new Dog("Spikey", 11), new Mouse("Jerry", 43.2)};

foreach (var animal in animals)
{
    var animalStats = animal.GetStats();
    Console.WriteLine(animalStats);
}