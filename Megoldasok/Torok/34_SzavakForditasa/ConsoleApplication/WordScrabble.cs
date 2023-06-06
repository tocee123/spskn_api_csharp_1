namespace ConsoleApplication;
public class WordScrabble
{
    public static string ReverseOnlyLetters(string sentence)
    {
        return sentence.Split(" ")
            .Select(s => s.ToCharArray().Reverse().Select(c => c.ToString()).JoinArray("")).JoinArray();
    }
}


public static class StringHelpers
{
    public static string JoinArray(this IEnumerable<string> strings, string separator = " ")
        => string.Join(separator, strings);
}