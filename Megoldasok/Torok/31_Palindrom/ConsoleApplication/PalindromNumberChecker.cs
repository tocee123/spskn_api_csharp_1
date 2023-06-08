namespace ConsoleApplication;

public class PalindromNumberChecker
{
    public static bool IsPalindrom(int number)
    {
        var exponentSearch = number;
        var exponent = 0;
        while (exponentSearch > 0)
        {
            exponent++;
            exponentSearch /= PowerOf10(exponent);
        }
        for (int i = 0; i < exponent; i++)
        {
            var leftNumber = number / PowerOf10(exponent - i);
            var rightNumber = number % PowerOf10(i);
            if (leftNumber != rightNumber)
            {
                return false;
            }
            number /= PowerOf10(exponent - i);
        }

        return true;
    }

    private static int PowerOf10(int exponent)
        => (int)Math.Pow(10, exponent);
}