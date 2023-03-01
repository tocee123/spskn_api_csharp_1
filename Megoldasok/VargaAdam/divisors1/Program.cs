Console.WriteLine("This program will write out numbers between a closed interval that can be divided by the divisor.");

Console.WriteLine("What's the lower limit?");
int lowerLimit = int.Parse(Console.ReadLine());
Console.WriteLine("What's the upper limit?");
int upperLimit = int.Parse(Console.ReadLine());
Console.WriteLine("Add a divisor number:");
int divisorNumber = int.Parse(Console.ReadLine());

Console.WriteLine("The following numbers are in the (closed) interval you've given:");

for (int i = lowerLimit; i <= upperLimit; i++)
{
    Console.Write(i);

    if (i < upperLimit)
    {
        Console.Write(", ");
    }

    else if (i == upperLimit)
    {
        Console.Write(".");   
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Numbers between {lowerLimit} and {upperLimit} that can be divided by {divisorNumber}:");

for (int i = lowerLimit; i <= upperLimit; i++)
{
    if (i == 0)
    {
        continue;
    }

    if (i % divisorNumber == 0)
    {
        if (i < upperLimit)
        {
            Console.Write(i + ",");
        }

        else
        {
            Console.Write(i);
        }
    }
}

Console.WriteLine(".");


Console.ReadLine();