namespace ConsoleApplication;

public class WordScrabble
{
    public static string ReverseOnlyLetters(string sentence)
    => sentence?.Split().Select(ReverseLetters).JoinArray()
        ?? sentence;

    public static string ReverseOnlyWords(string sentence)
    => sentence?.Split().Reverse().JoinArray()
        ?? sentence;

    public static string ReverseWordsAndLetters(string sentence)
    => sentence?.Split().Select(ReverseLetters).Reverse().JoinArray()
        ?? sentence;

    private static string CallSteps(string sentence, Func<string, string> reverseLetters, Func<IEnumerable<string>, IEnumerable<string>> reverseWords)
    {
        if (sentence == null)
        {
            return sentence;
        }
        return sentence.Split()
            .Select(reverseLetters)
            .Callmethod(reverseWords)
            .JoinArray();
    }

    private static string ReverseLetters(string s)
    => s.ToCharArray().Reverse().Select(c => c.ToString()).JoinArray("");
}