namespace _03_ArraysAndLists;

internal class _06_TombokElemenekValtoztatasa
{
    public static void IrjadKi()
    {
        var szamok = new int[] { 10, 30, 60 };

        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine(szamok[i]);
        }

        szamok[1] = 101;
        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine(szamok[i]);
        }
    }
}

