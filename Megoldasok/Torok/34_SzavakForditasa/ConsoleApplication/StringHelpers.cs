namespace ConsoleApplication;

public static class StringHelpers
{
    public static string JoinArray(this IEnumerable<string> strings, string separator = " ")
        => string.Join(separator, strings);
}