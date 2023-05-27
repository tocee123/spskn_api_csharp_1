namespace _03_ArraysAndLists;

internal class _04_TombokInicilizacio
{
    public static void IrjadKi()
    {
        var szamok = new int[] { 10, 30, 60 };

        Console.WriteLine(szamok[0]);
        Console.WriteLine(szamok[1]);
        Console.WriteLine(szamok[2]);

        var szamok1 = new[] {10, 30, 60 };

        Console.WriteLine(szamok1[0]);
        Console.WriteLine(szamok1[1]);
        Console.WriteLine(szamok1[2]);

        int[] szamok2 = {10, 30, 60 };

        Console.WriteLine(szamok2[0]);
        Console.WriteLine(szamok2[1]);
        Console.WriteLine(szamok2[2]);

        int[] szamok3 = new int[4];
        szamok3[3] = 101;
    }
}

