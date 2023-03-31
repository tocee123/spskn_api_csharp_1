namespace _03_BMI_Calculator.BmiCalculators
{
    internal abstract class BmiCalculatorBase
    {
        public void ShowBmi()
        {
            var height = GetHeight();
            var weight = GetWeight();
            float dividedHeight = height / GetHeightDividor();
            float BMIMetric = GetBmiMultiplier() * weight / (dividedHeight * dividedHeight);
            Console.Clear();
            Console.WriteLine($"BMI: {BMIMetric:F2}");
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(BMIList.ToString());
            Console.ResetColor();
        }

        private float GetWeight() => GetMeasurement(GetWeightText(), "weight");
        private float GetHeight() => GetMeasurement(GetHeightText(), "height");

        private static float GetMeasurement(string promptText, string measurementName)
        {
            Console.WriteLine(promptText);
            float value;
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out value))
                {
                    break;
                }
                Console.WriteLine($"Invalid input! Please enter a valid {measurementName} value.");
            }
            return value;
        }

        protected virtual int GetHeightDividor() => 1;

        protected virtual int GetBmiMultiplier() => 1;

        protected abstract string GetHeightText();

        protected abstract string GetWeightText();
    }
}
