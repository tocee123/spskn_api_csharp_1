int numberOfSpaces = 0;

do
{
    Console.Write("Adjal meg egy egesz szamot 0 es 20 kozott:");
    if (int.TryParse(Console.ReadLine(), out numberOfSpaces) && 0 < numberOfSpaces && numberOfSpaces < 20)
    {
        break;
    }
} while (true);

Console.WriteLine($"{new string(' ', numberOfSpaces)}START");

