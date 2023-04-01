using _03_BMI_Calculator.BmiCalculators;

internal class Program
{
    private static void Main(string[] args)
    {
        var calculator = GetBmiCalculator();
        calculator.ShowBmi();
    }

    private static BmiCalculatorBase GetBmiCalculator()
        {
        var mapping = new Dictionary<string, BmiCalculatorBase>
        {
            ["m"] = new MetricBmiCalculator(),
            ["i"] = new ImperialBmiCalculator()
        };
        string? mode;
        while (true)
        {
            Console.WriteLine("Choose a mode: Metric (M), Imperial (I)");
            mode = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.WriteLine();
            if (mapping.ContainsKey(mode))
            {
                break;
            }
            Console.WriteLine("Invalid mode selection. Please enter 'M' or 'I' ");
        }

        return mapping[mode];
    }
}
