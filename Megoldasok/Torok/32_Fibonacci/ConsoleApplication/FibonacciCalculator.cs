namespace ConsoleApplication;

public class FibonacciCalculator
{
    public static int CalculateNthElement(int input)
    {
        var list = new List<int> { 0, 1 };
        if (input < list.Count)
        {
            return list[input];
        }

        for (int i = 2; i <= input; i++)
        {
            list.Add(list[i - 2] + list[i - 1]);
        }

        return list[input];
    }
}