namespace ConsoleApplication;
public class TextReverser
{
    public static string ReverseUsingForwardForCycle(string text)
    {
        var result = "";
        for (int i = 0; i < text.Length; i++)
        {
            result += text[text.Length - 1 - i];
        }

        return result;

    }
    public static string ReverseUsingBackwardForCycle(string text)
    {
        var result = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            result += text[i];
        }

        return result;
    }
    public static string ReverseUsingWhileCycle(string text)
    {
        var result = "";
        var i = text.Length - 1;
        while(i >= 0)
        {
            result += text[i];
            i--;
        }
        return result;
    }
}