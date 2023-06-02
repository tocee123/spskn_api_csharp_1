namespace ConsoleApplication;
public class PalindromChecker
{
    public static bool IsPalindrom(string input)
    {
        var characters = input.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] != characters[characters.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}