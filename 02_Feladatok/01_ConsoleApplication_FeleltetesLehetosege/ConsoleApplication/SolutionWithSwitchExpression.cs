namespace ConsoleApplication
{
    internal class SolutionWithSwitchExpression
    {
        public static void Run()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Felés esély számológép\n");
            Console.ResetColor();
            int peopleThatCanHaveAGrade = ReadIntAnswer("Az emberek száma a csoportban: ");
            int peopleThatAlreadyHaveAGrade = ReadIntAnswer("Az emberek száma akik már feleltek: ");
            double chancePercentage = CalculatePercentageOfPotentionalPeople(peopleThatCanHaveAGrade, peopleThatAlreadyHaveAGrade);
            WritePercentageWithDifferentColor(chancePercentage);
        }

        private static void WritePercentageWithDifferentColor(double chancePercentage)
        {
            Console.ForegroundColor = GetColorByPercentage(chancePercentage);
            Console.WriteLine($"Minden hátramaradó embernek van {Math.Round(chancePercentage, 2)}% esélye felelésre.");
            Console.ResetColor();
        }

        private static ConsoleColor GetColorByPercentage(double chancePercentage)
            => chancePercentage switch
            {
                <= 5 => ConsoleColor.Green,
                <= 10 => ConsoleColor.DarkYellow,
                <= 25 => ConsoleColor.Yellow,
                <= 50 => ConsoleColor.Red,
                _ => ConsoleColor.DarkRed
            };

        private static double CalculatePercentageOfPotentionalPeople(int peopleThatCanHaveAGrade, int peopleThatAlreadyHaveAGrade)
            => (1.0 / (peopleThatCanHaveAGrade - peopleThatAlreadyHaveAGrade) * 100);

        private static int ReadIntAnswer(string question)
        {
            Console.WriteLine(question);
            return int.TryParse(Console.ReadLine(), out var answer)
                ? answer
                : 0;
        }
    }
}
