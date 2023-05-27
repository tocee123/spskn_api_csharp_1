namespace _03_ArraysAndLists;

internal class _07_TombSorbaRendezese
{
    public static void IrjadKi()
    {
        var szamok = new[] { 10, 30, 60, -10, 98, -90, 0, 1, 12 };

        //for (int i = 0; i < szamok.Length; i++)
        //{
        //    Console.WriteLine(szamok[i]);
        //}

        Array.Sort(szamok);
        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine(szamok[i]);
        }
    }
}

