Console.Write("Give me your name: ");
var name = Console.ReadLine();
Console.Write("How old are you? ");
int.TryParse(Console.ReadLine(), out var age);

Console.WriteLine($"Hello {name}! You are {age} years old, you are{(age < 18 ? " not" : "")} an adult.");