Console.WriteLine("In this program type a number and until there you can choose what to display.");
Console.WriteLine("1 - only prime numbers\n2 - only not prime numbers\n3 - prime numbers and not prime numbers");
var choice = int.Parse(Console.ReadLine());
Console.WriteLine("Until this number: ");
Console.ForegroundColor = ConsoleColor.Cyan;
var number = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.ResetColor();

if (choice == 1)    // choice - 1 prime
{
    for (int numberUntilGiven = 2; numberUntilGiven <= number; numberUntilGiven++)
    {
        var prime = true;
        for (var i = 2; i <= Math.Sqrt(numberUntilGiven); i++)
        {
            if (numberUntilGiven % i == 0)
            {
                prime = false;
                break;

            }
        }
        if (prime)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{numberUntilGiven} is Prime");
            Console.ResetColor();
        }
    }
}



if (choice == 2)    // choice - 2 not prime
{
    for (int numberUntilGiven = 2; numberUntilGiven <= number; numberUntilGiven++)
    {
        var prime = true;
        for (var i = 2; i <= Math.Sqrt(numberUntilGiven); i++)
        {
            if (numberUntilGiven % i == 0)
            {
                prime = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{numberUntilGiven} is not Prime --> {i}*{numberUntilGiven / i} = {numberUntilGiven} ");
                Console.ResetColor();
                break;

            }
        }
    }
}




if (choice == 3)    // choice - 3 prime and not
{
    for (int numberUntilGiven = 2; numberUntilGiven <= number; numberUntilGiven++)
    {
        var prime = true;
        for (var i = 2; i <= Math.Sqrt(numberUntilGiven); i++)
        {
            if (numberUntilGiven % i == 0)
            {
                prime = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{numberUntilGiven} is not Prime --> {i}*{numberUntilGiven / i} = {numberUntilGiven} ");
                Console.ResetColor();
                break;

            }
        }
        if (prime)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{numberUntilGiven} is Prime");
            Console.ResetColor();
        }
    }
}