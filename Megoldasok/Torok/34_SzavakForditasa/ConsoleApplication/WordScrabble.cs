namespace ConsoleApplication;

public class WordScrabble
{
    public static string ReverseOnlyLetters(string sentence)
    => CallSteps(sentence, ReverseLetters, s => s);

    public static string ReverseOnlyWords(string sentence)
    => CallSteps(sentence, s => s, s => s.Reverse());

    public static string ReverseWordsAndLetters(string sentence)
    => CallSteps(sentence, ReverseLetters, s => s.Reverse());

    private static string CallSteps(string sentence, Func<string, string> reverseLetters, Func<IEnumerable<string>, IEnumerable<string>> reverseWords)
    => sentence?.Split()
            .Select(reverseLetters)
            .Callmethod(reverseWords)
            .JoinArray()
        ?? sentence;

    private static string ReverseLetters(string s)
    => s.ToCharArray().Reverse().Select(c => c.ToString()).JoinArray("");
}