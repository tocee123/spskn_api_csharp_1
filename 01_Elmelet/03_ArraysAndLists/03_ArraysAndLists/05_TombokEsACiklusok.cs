namespace _03_ArraysAndLists;

internal class _05_TombokEsACiklusok
{
    public static void IrjadKi()
    {
        var szamok = new int[] { 10, 30, 60 };

        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine(szamok[i]);
        }

        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine($"Az {i+1}. szam: {szamok[i]}");
        }

        foreach (var i in szamok)
        {
            Console.WriteLine(i);
        }
    }
}

