namespace ConsoleApplication;

public class FibonacciCalculator
{
    public static int CalculateNthElement(int input)
    {
        if (input == 0) return 0;
        if (input == 1) return 1;
        int previous = 1;
        int result = 1;

        for (int i = 2; i<input;i++)
        {
            previous = result;
            result += previous;            
        }

        return result;
    }
}