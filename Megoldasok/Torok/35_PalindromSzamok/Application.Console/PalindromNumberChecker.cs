namespace Application.Console;

public class PalindromNumberChecker
{
    private static int _numberBase = 10;
    public static bool IsPalindrom(int number)
    {
        var exponent = FindExponent(number);
        for (int i = 0; i < exponent; i++)
        {

            if (!AreTwoSideNumbersEqual(number, exponent, i))
            {
                return false;
            }
        }

        return true;
    }

    private static bool AreTwoSideNumbersEqual(int number, int maxExponent, int currentExponent)
    {
        var leftNumber = (number / PowerOf10(maxExponent - currentExponent)) % _numberBase;
        var rightNumber = (number / PowerOf10(currentExponent)) % _numberBase;
        return leftNumber == rightNumber;
    }

    private static int FindExponent(int number)
    {
        var exponentSearch = number;
        var exponent = -1;
        while (exponentSearch > 0)
        {
            exponent++;
            exponentSearch /= _numberBase;
        }
        return exponent;
    }

    private static int PowerOf10(int exponent)
        => (int)Math.Pow(_numberBase, exponent);
}