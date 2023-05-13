public class PrimeFactorization
{
    //Asks user for input, code currently breaks if the input is too high or not correct o.o
    public static void Main()
    {
        Console.Write("Enter a number between 0 and 1000: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime factorization: " + GetPrimeFactors(number));
    }

    //Does the calculations and returns it to Main()
    public static string GetPrimeFactors(int number)
    {
        string primeFactors = "";
        int divisor = 2;

        while (number > 1)
        {
            if (number % divisor == 0) //if its a whole number
            {
                primeFactors += divisor + "*";
                number /= divisor;
            }
            else
            {
                divisor++; //keeps adding 1 to the divisor if it can't be divised by the previous divisor
            }
        }

        primeFactors = primeFactors.TrimEnd('*'); //removes the * from the end of the line

        return primeFactors;
    }
}
