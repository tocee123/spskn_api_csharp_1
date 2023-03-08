namespace ConsoleApplication
{
    internal class SolutionWithIf
    {
        public static void Run()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Felés esély számológép\n");
            Console.ResetColor();
            Console.WriteLine("Az emberek száma a csoportban: ");
            int peopleThatCanHaveAGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Az emberek száma akik már feleltek: ");
            int peopleThatAlreadyHaveAGrade = int.Parse(Console.ReadLine());
            int percentageOfPotentialPeople = (peopleThatCanHaveAGrade - peopleThatAlreadyHaveAGrade);
            double chancePercentage = (1.0 / percentageOfPotentialPeople * 100);
            string totalChanceText = $"Minden hátramaradó embernek van {Math.Round(chancePercentage, 2)}% esélye felelésre.";

            if (chancePercentage <= 5) //from 0 to 5 percent
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else if (chancePercentage <= 10) //from 6 to 10
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            else if (chancePercentage <= 25) //from 11 to 25
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            else if (chancePercentage <= 50) //from 26 to 50
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            else if (chancePercentage <= 100) //from 51 to 100
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }

            Console.WriteLine(totalChanceText);
            Console.ResetColor();
        }
    }
}
