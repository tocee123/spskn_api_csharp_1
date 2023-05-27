namespace _03_ArraysAndLists;

internal class _09_Listak
{
    public static void IrjadKi()
    {
        var szamok = new List<int>();
        szamok.Add(1);
        szamok.Add(-15);
        szamok.Add(0);
        szamok.Remove(1);
        szamok.RemoveAt(1);
        szamok.Insert(0, 15);
        //szamok[1] = 90;

        Console.WriteLine($"a {nameof(szamok)} listaban {szamok.Count()} elem talalhato");
        foreach (int i in szamok)
        {
            Console.WriteLine(i);
        }
    }
}

