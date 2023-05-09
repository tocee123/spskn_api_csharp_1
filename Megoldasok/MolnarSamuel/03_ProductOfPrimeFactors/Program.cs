
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Enter a number and its prime factor resolution will be displayed. ");

Console.ForegroundColor = ConsoleColor.Yellow;
var inputtedNumber = int.Parse(Console.ReadLine());

while (inputtedNumber < 0) 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter a number which is not negative! ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    inputtedNumber = int.Parse(Console.ReadLine());
    if (inputtedNumber >= 0) 
    {
        Console.ResetColor();
        break;
    }
}



static void IfNumberOneOrZero(int inputtedNumber) 
{
    if (inputtedNumber == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Number {inputtedNumber}'s prime factor resolution is: 1");
    }

    else if (inputtedNumber == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Number 0 has no divisors.");
    }
    Console.ResetColor();
}

static void PrimeFactorResolution(int inputtedNumber)  // this does the job
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Number {inputtedNumber}'s prime factor resolution is: ");
    for (int i = 2; i <= inputtedNumber; i++)
    {
        while (inputtedNumber % i == 0)
        {
            int displayedNumber = i;
            inputtedNumber = inputtedNumber / i;
            Console.Write($"{displayedNumber}");  // if no more numbers, do not write a star
            if (i <= inputtedNumber)
            {
                Console.Write(" * ");
            }
        }
    }
    Console.ResetColor();
}

if (inputtedNumber > 1)
{
    PrimeFactorResolution(inputtedNumber);
}

else if (inputtedNumber == 1 || inputtedNumber == 0) 
{
    IfNumberOneOrZero(inputtedNumber);
}
