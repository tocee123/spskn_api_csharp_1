List<int> numbers = new List<int>(); //creates new list as "numbers"
int userInput; 

Console.WriteLine("Enter whole numbers (enter 0 to stop):");

do
{
    userInput = Convert.ToInt32(Console.ReadLine()); //reads userinput and converts it to 32bit

    if (userInput != 0)
    {
        numbers.Add(userInput);
    }
}
while (userInput != 0);

numbers.Sort(); //sorts numbers

int amount = numbers.Count;
int partNumber = numbers[numbers.Count / 2];
double average = numbers.Count > 0 ? numbers.Average() : 0;

Console.WriteLine();
Console.WriteLine($"Amount: {amount}");
Console.WriteLine($"Part number: {partNumber}");
Console.WriteLine($"Average: {average}");

Console.WriteLine("\nEnter the number of pieces (not more than 10):");
int numPieces = Convert.ToInt32(Console.ReadLine());

int[] pieces = new int[numPieces];
int sum = 0;

Console.WriteLine($"Enter {numPieces} integers:");

for (int i = 0; i < numPieces; i++)
{
    pieces[i] = Convert.ToInt32(Console.ReadLine());
    sum += pieces[i];
}

double averagePieces = numPieces > 0 ? sum / (double)numPieces : 0;

Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Number of pieces: {numPieces}");
Console.WriteLine($"Average: {averagePieces}");