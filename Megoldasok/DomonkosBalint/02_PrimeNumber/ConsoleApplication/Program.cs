using System;

class PrimeNumberCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
        (1) Only prime numbers
        (2) Only not prime numbers
        (3) Every number, combination of 1 and 2
        ");

        int[] validModes = new int[] { 1, 2, 3 };
        int mode = GetValidInput(validModes);
        Console.WriteLine($"Selected Mode: {mode}");
        int lowerLimit = GetLowerLimit();
        int upperLimit = GetUpperLimit(lowerLimit);
        int selectedMode = 0;
        switch (mode)
        {
            case 1: // ONLY prime numbers
                selectedMode = mode;
                PrintPrimeNumbers(lowerLimit, upperLimit);
                break;

            case 2: // ONLY not prime numbers
                selectedMode = mode;
                PrintNotPrimeNumbers(lowerLimit, upperLimit);
                break;

            case 3: // Every number, combination of 1 and 2
                selectedMode = mode;
                PrintAllNumbers(lowerLimit, upperLimit);
                break;
        }
    }

    static void PrintPrimeNumbers(int lowerLimit, int upperLimit)
    {
        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();
    }

    static void PrintNotPrimeNumbers(int lowerLimit, int upperLimit)
    {
        Random random = new Random();

        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (!IsPrime(i))
            {
                Console.WriteLine(i);

                // Generate two random numbers whose multiples equal the non-prime number
                int num1 = random.Next(2, i);
                int num2 = i / num1;

                Console.WriteLine($"Random Multiples of {i}: {num1} and {num2}");
            }
        }
    }

    static void PrintAllNumbers(int lowerLimit, int upperLimit)
    {
        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            bool isPrime = IsPrime(i);
            Console.WriteLine($"{i} {(isPrime ? "is prime" : "is not prime")}");

            if (!isPrime)
            {
                int[] multiples = GetRandomMultiples(i);
                Console.WriteLine($"Random Multiples of {i}: {multiples[0]} and {multiples[1]}");
            }
        }
        Console.WriteLine();
    }

    static int[] GetRandomMultiples(int number)
    {
        Random random = new Random();
        int[] multiples = { 0, 0 };

        while (multiples[0] * multiples[1] != number)
        {
            multiples[0] = random.Next(2, number);
            multiples[1] = number / multiples[0];
        }

        return multiples;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int GetValidInput(int[] validModes)
    {
        int input;

        while (true)
        {
            if (!int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid input. Please enter an integer.");
                Console.ResetColor();
                continue;
            }

            if (!validModes.Contains(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid mode. Please enter a correct mode ({0}).", string.Join(", ", validModes));
                Console.ResetColor();
                continue;
            }

            return input;
        }
    }

    static int GetLowerLimit()
    {
        int input;

        while (true)
        {
            Console.WriteLine("Enter the lower limit:");
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid input. Please enter an integer.");
                Console.ResetColor();
                continue;
            }

            return input;
        }
    }

    static int GetUpperLimit(int lowerLimit)
    {
        int input;

        while (true)
        {
            Console.WriteLine("Enter the upper limit (greater than lower limit):");
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid input. Please enter an integer.");
                Console.ResetColor();
                continue;
            }

            if (input <= lowerLimit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Upper limit must be greater than the lower limit.");
                Console.ResetColor();
                continue;
            }

            return input;
        }
    }
}
