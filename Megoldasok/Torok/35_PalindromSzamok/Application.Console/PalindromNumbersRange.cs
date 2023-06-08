namespace Application.Console;

public class PalindromNumbersRange
{
    public static IEnumerable<int> GetPalindromNumbers(int lowerBorder, int upperBorder)
    {
        if (lowerBorder > upperBorder || new[] { lowerBorder, upperBorder }.Any(x => x < 0))
        {
            throw new BorderNotCorrectException();
        }

        return null;
    }
}
