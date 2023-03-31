namespace _03_BMI_Calculator.BmiCalculators
{
    internal class MetricBmiCalculator : BmiCalculatorBase
    {
        protected override int GetHeightDividor() => 100;

        protected override string GetHeightText() => "Enter height in centimeters (cm):";

        protected override string GetWeightText() => "Enter weight in kilograms (kg):";
    }
}
