string start_message = "This is a dice program.\nThrow -> Any key\nQuit -> Q";
Console.WriteLine(start_message);

var rolledNumbers = new Dictionary<int, int>();

string dice_throw = Console.ReadLine();

while (dice_throw != "Q")
{
    int random_number = new Random().Next(1, 7);
    Console.Write($"Thrown number: {random_number}");
    rolledNumbers[random_number] = rolledNumbers.ContainsKey(random_number)? rolledNumbers[random_number] + 1 : 0;

    Console.WriteLine("\nThrow again?");
    dice_throw = Console.ReadLine();
}

var totalRolled = rolledNumbers.Sum(x => x.Value);
Console.WriteLine($"You've thrown number 6 this many times: {rolledNumbers[6]}");
Console.WriteLine($"You've thrown this many times: {totalRolled}");

foreach (var kvp in rolledNumbers)
{
    Console.WriteLine($"#{kvp.Key} was rolled {kvp.Value} times, that is\t{(float)kvp.Value*100/totalRolled:F2}%");
}