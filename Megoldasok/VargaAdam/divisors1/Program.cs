string infoOne = "The following numbers are in the (closed) interval you've given:";


Console.WriteLine("This program will write out numbers between a closed interval that can be divided by the divisor.");

Console.WriteLine("What's the first limit?");
int firstLimit = int.Parse(Console.ReadLine());
Console.WriteLine("What's the second limit?");
int secondLimit = int.Parse(Console.ReadLine());
Console.WriteLine("Add a divisor number:");
int divisorNumber = int.Parse(Console.ReadLine());


if (firstLimit < secondLimit)
{
    Console.WriteLine(infoOne);

    for (int i = firstLimit; i <= secondLimit; i++)
    {
        Console.Write(i);

        if (i < secondLimit)
        {
            Console.Write(", ");
        }

        else if (i == secondLimit)
        {
            Console.Write(".");
        }
    }
}

else if (firstLimit > secondLimit)
{
    Console.WriteLine(infoOne);

    for (int k = secondLimit; k <= firstLimit; k++)
    {
        Console.Write(k);

        if (k < firstLimit)
        {
            Console.Write(", ");
        }

        else if (k == firstLimit)
        {
            Console.Write(".");
        }
    }
}

else if (firstLimit == secondLimit)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The two borders cannot be equal to each other.");
    Console.ResetColor();
    Console.ReadLine();
    Environment.Exit(0);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Numbers between {firstLimit} and {secondLimit} that can be divided by {divisorNumber}:");

if (firstLimit < secondLimit)
{
    for (int i = firstLimit; i <= secondLimit; i++)
    {
        if (i == 0)
        {
            continue;
        }


        if (i % divisorNumber == 0)
        {
            Console.Write(i + ", ");
        }

        if (i == secondLimit)
        {
            Console.Write(".");
        }
    }
}

else if (firstLimit > secondLimit)
{
    for (int j = secondLimit; j <= firstLimit; j++)
    {
        if (j == 0)
        {
            continue;
        }


        if (j % divisorNumber == 0)
        {
            Console.Write(j + ", ");
        }

        if (j == firstLimit)
        {
            Console.Write(".");
        }
    }
}



Console.ReadLine();