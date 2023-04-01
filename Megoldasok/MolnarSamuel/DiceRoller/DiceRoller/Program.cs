string start_message = "This is a dice program.\nThrow -> Any key\nQuit -> Q";
Console.WriteLine(start_message);

string dice_throw = Console.ReadLine();
int throw_counter = 0;
int num_6_counter = 0;

while (dice_throw != "Q")
{
    int random_number = new Random().Next(1, 7);
    Console.Write($"Thrown number: {random_number}");
    throw_counter++;
	
	num_6_counter += random_number == 6 ? 1 : 0
    Console.WriteLine("\nThrow again?");
    dice_throw = Console.ReadLine();
}

Console.WriteLine($"You've thrown number 6 this many times: {num_6_counter}");
Console.WriteLine($"You've thrown this many times: {throw_counter}");

if (num_6_counter == 0)
{
    Console.WriteLine("Your luck to number 6 is 0%\nI feel bad for you :(");
}
else if (num_6_counter >= 1)
{
    int luckInPercentage = 100 * num_6_counter / throw_counter;
    Console.WriteLine($"Your luck to number 6 in percentage: {luckInPercentage}%");
}
