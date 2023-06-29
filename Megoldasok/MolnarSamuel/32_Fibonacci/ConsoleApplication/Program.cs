static void Fibonacci(int length)
{
    int a = 0;
    int b = 1;
    int outputNum = 0;
    Console.WriteLine("Do you want to see all the numbers or only the last one?\n0 -> all\n1 -> only one");
    string choice = Console.ReadLine();
    Console.ResetColor();
    if (choice == "0")
    {
        Console.Write($"{a}, {b}");
        for (int i = 1; i < length; i++)
        {
            outputNum = a + b;
            Console.Write($", {outputNum}");
            a = b;
            b = outputNum;
        }
    }
    else
    {
        for (int i = 1; i < length; i++)
        {
            outputNum = a + b;
            
            a = b;
            b = outputNum;
        }
        Console.WriteLine(outputNum);
    }
}

Console.WriteLine("In the Fibonacci series which positioned number do you want to see?");
Console.ForegroundColor = ConsoleColor.Cyan;
int length = int.Parse(Console.ReadLine());
Fibonacci(length);
