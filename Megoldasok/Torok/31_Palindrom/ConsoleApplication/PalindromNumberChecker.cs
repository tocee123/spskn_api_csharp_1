namespace ConsoleApplication;

public class PalindromNumberChecker
{
    public static bool IsPalindrom(int number)
    {
        var exponent = FindExponent(number);
        for (int i = 0; i < exponent; i++)
        {
            var leftNumber = (number / PowerOf10(exponent - i)) % 10;
            var rightNumber = (number / PowerOf10(i)) % 10;
            if (leftNumber != rightNumber)
            {
                return false;
            }
        }

        return true;
    }

    private static int FindExponent(int number)
    {
        var exponentSearch = number;
        var exponent = -1;
        while (exponentSearch > 0)
        {
            exponent++;
            exponentSearch /= 10;
        }
        return exponent;
    }

    private static int PowerOf10(int exponent)
        => (int)Math.Pow(10, exponent);
}