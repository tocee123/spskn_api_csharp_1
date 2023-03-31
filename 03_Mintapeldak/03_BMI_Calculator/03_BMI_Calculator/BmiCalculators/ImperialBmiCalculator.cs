namespace _03_BMI_Calculator.BmiCalculators
{
    internal class ImperialBmiCalculator : BmiCalculatorBase
    {
        protected override int GetBmiMultiplier() => 703;

        protected override string GetHeightText() => "Enter height in inches (inch):";

        protected override string GetWeightText() => "Enter weight in pounds (lbs):";
    }
}
