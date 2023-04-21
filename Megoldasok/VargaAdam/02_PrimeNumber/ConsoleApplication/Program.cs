internal class Program
{
    private static void Main(string[] args)
    {
        bool shouldRestartProgram = true;

        while (shouldRestartProgram == true)
        {
            Console.WriteLine("------Prime numbers calculator------\n\nThis program will find the prime numbers for you until an upper limit. You can choose:\n1 - just the prime numbers\n2 - numbers that are not prime numbers\n3 - both\n4 - exit");
            int modeNumber = int.Parse(Console.ReadLine());
            
            if (modeNumber == 4)
            {
                Environment.Exit(0);
            }

            Console.WriteLine("What's the upper limit?");
            int upperLimit = int.Parse(Console.ReadLine());

            if (modeNumber == 1)
            {
                Console.WriteLine("You have chosen to only show the prime numbers:");

                for (int i = 2; i <= upperLimit; i++)
                {
                    

                    if (IsPrime(i))
                    {
                        Console.WriteLine(i + " is a prime number.");
                    }
                }
            }

            else if (modeNumber == 2)
            {
                Console.WriteLine("You have chosen to only show the non prime numbers:");
                Console.WriteLine("1 is not considered as a prime number.");

                for (int i = 2; i <= upperLimit; i++)
                {
                    bool isPrimeNumber = true;

                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }

                    if (isPrimeNumber == false)
                    {
                        Console.WriteLine(i + " is not a prime number.");
                    }
                }
            }

            else if (modeNumber == 3)
            {
                Console.WriteLine("You have chosen to show both non prime numbers and prime numbers:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 is not considered as a prime number.");
                Console.ResetColor();

                for (int i = 2; i <= upperLimit; i++)
                {
                    bool isPrimeNumber = true;

                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrimeNumber = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(i + " is not a prime number, because: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{j} * {i / j} = {i}");
                            break;
                        }
                    }

                    if (isPrimeNumber == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i + " is a prime number.");
                    }

                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Do you want to restart the program? true/false");
            Console.ResetColor();
            shouldRestartProgram = Convert.ToBoolean(Console.ReadLine());
        }

        static bool IsPrime(int i)
        {
            bool isPrimeNumber = true;

            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }

            return isPrimeNumber;
        }
    }
}