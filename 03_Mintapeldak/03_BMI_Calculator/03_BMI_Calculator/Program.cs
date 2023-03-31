internal class Program
{
    private static void Main(string[] args)
    {

        string BMIList = @"
        <15        Very severely underweight
        15-16      Severely underweight
        16-18.5    Underweight
        18.5-25    Normal(healthy weight)
        25-30      Overweight
        30-35      Moderately obese
        35-40      Severely obese
        >40        Very severely obese
        ";


        char mode = '\0';
        bool validMode = false;

        while (!validMode)
        {
            Console.WriteLine("Choose a mode: Metric (M), Imperial (I)");
            mode = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (mode == 'm' || mode == 'M' || mode == 'i' || mode == 'I')
            {
                validMode = true;
            }
            else
            {
                Console.WriteLine("Invalid mode selection. Please enter 'M' or 'I' ");
            }
        }

        if (mode == 'm' || mode == 'M')
        {
            Console.Clear();
            Console.WriteLine("[Metric selected]\n");
            float weightMetric;
            float heightMetricCentimeter;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Enter weight in kilograms (kg):");
                if (float.TryParse(Console.ReadLine(), out weightMetric))
                {
                    Console.WriteLine("Enter height in centimeters (cm):");
                    if (float.TryParse(Console.ReadLine(), out heightMetricCentimeter))
                    {
                        validInput = true;
                        float heightMetricMeter = heightMetricCentimeter / 100;
                        float BMIMetric = weightMetric / (heightMetricMeter * heightMetricMeter);
                        Console.Clear();
                        Console.WriteLine($"BMI: {BMIMetric:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid height value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid weight value.");
                }
            }
        }

        else
        {
            Console.Clear();
            Console.WriteLine("[Imperial selected]\n");
            float weightImperial;
            float heightImperial;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Enter weight in pounds (lbs):");
                if (float.TryParse(Console.ReadLine(), out weightImperial))
                {
                    Console.WriteLine("Enter height in inches (inch):");
                    if (float.TryParse(Console.ReadLine(), out heightImperial))
                    {
                        validInput = true;
                        float BMIImperial = 703 * weightImperial / (heightImperial * heightImperial);
                        Console.Clear();
                        Console.WriteLine($"BMI: {BMIImperial:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid height value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid weight value.");
                }
            }

        }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(BMIList.ToString());
        Console.ResetColor();
    }
}