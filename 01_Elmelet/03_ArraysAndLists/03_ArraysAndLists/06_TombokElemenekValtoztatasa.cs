namespace _03_ArraysAndLists;

internal class _06_TombokElemenekValtoztatasa
{
    public static void IrjadKi()
    {
        var szamok = new[] { 10, 30, 60 };

        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine(szamok[i]);
        }

        szamok[1] = 101;
        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine(szamok[i]);
        }

        //foreach-ben nem lehet a ciklulsvaltozo erteket valtoztatni
        //foreach (var i in szamok)
        //{
        //    i = i * 2;
        //    Console.WriteLine(i);
        //}
    }
}

