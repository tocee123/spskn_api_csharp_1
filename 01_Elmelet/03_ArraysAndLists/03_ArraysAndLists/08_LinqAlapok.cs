using System.Collections.Immutable;

namespace _03_ArraysAndLists;

internal class _08_LinqAlapok
{
    public static void IrjadKi()
    {
        var szamok = new[] { 10, 30, 60, -10, 98, -90, 0, 1, 12 };

        Console.WriteLine(szamok.Count());
        Console.WriteLine(szamok.Max());
        Console.WriteLine(szamok.Min());
        Console.WriteLine(szamok.Sum());

        Console.WriteLine();
        //Visszaad erteket
        foreach (int i in szamok.Order())
        {
            Console.WriteLine(i);
        }
    }
}

