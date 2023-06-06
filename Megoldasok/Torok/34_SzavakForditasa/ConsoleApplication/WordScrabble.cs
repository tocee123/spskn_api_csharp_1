namespace ConsoleApplication;

public class WordScrabble
{
    public static string ReverseOnlyLetters(string sentence)
    => sentence?.Split()
            .Select(ReverseLetters).JoinArray()
        ?? sentence;

    public static object ReverseOnlyWords(string sentence)
    => sentence?.Split().Reverse().JoinArray()
        ?? sentence;

    public static object ReverseWordsAndLetters(string sentence)
    => sentence?.Split()
            .Select(ReverseLetters).Reverse().JoinArray()
        ?? sentence;

    private static string ReverseLetters(string s)
    => s.ToCharArray().Reverse().Select(c => c.ToString()).JoinArray("");
}