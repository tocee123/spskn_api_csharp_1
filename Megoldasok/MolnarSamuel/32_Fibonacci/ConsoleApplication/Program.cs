static void CalculateFibonacci(int length)
{
    var FibonacciNumbers = new int[length];
    int a = 0;
    int b = 1;
    int outputNum = 0;

    FibonacciNumbers[0] = 0;
    FibonacciNumbers[1] = 1;
    
    for (int i = 1; i < length; i++)
    {
        outputNum = a + b;
        FibonacciNumbers[i] = outputNum;
        a = b;
        b = outputNum;
    }
    DisplayFibonacci(length, FibonacciNumbers);
}

static void DisplayFibonacci(int length, int[] FibonacciNumbers) 
{
    Console.WriteLine("Do you want to see all the numbers or only the last one?\n0 -> all\n1 -> only one");
    string choice = Console.ReadLine();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    if (choice == "0") 
    {
        Console.Write("0, 1");
        for (int i = 1; i < FibonacciNumbers.Length; i++)
        {
            Console.Write($", {FibonacciNumbers[i]}");
        }
    }
    
    else 
    {
        Console.WriteLine(FibonacciNumbers[length - 1]);
    }
    Console.ResetColor();
}

Console.WriteLine("In the Fibonacci series which positioned number do you want to see?");
Console.ForegroundColor = ConsoleColor.Cyan;
int length = int.Parse(Console.ReadLine());

CalculateFibonacci(length);
