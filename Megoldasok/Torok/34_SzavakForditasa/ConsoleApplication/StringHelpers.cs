namespace ConsoleApplication;

public static class StringHelpers
{
    public static string JoinArray(this IEnumerable<string> strings, string separator = " ")
        => string.Join(separator, strings);

    public static IEnumerable<string> Callmethod(this IEnumerable<string> strings, Func<IEnumerable<string>, IEnumerable<string>> func)
        => func(strings);
}