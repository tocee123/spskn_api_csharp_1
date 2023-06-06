namespace ConsoleApplication;

public class WordScrabble
{
    public static string ReverseOnlyLetters(string sentence)
    => sentence?.Split(" ")
            .Select(s => s.ToCharArray().Reverse().Select(c => c.ToString()).JoinArray("")).JoinArray()
        ?? sentence;

    public static object ReverseOnlyWords(string input)
    {
        throw new NotImplementedException();
    }
}