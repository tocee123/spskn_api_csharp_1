
Console.WriteLine("Enter a number and its prime factor resolution will be displayed. ");

var inputtedNumber = int.Parse(Console.ReadLine());
var isPrime = true;
for (var i = 2; i <= Math.Sqrt(inputtedNumber); i++)
{
    if (inputtedNumber % i == 0)
    {
        isPrime = false;
        break;

    }
}
if (isPrime)   //if the inputted number is prime then needing to write out only 1 number
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Your number's prime factor resolution is (your number is prime): {inputtedNumber}");
    Console.ResetColor();
}
else    // here comes everything actually
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Your number's prime factor resolution is: ");
    for (int i = 2; i <= inputtedNumber; i++) 
    {
        while (inputtedNumber % i == 0)
        {
            int displayedNumber = i;
            inputtedNumber = inputtedNumber / i;
            Console.Write($"{displayedNumber}");  // if no more numbers, do not write a star
            if (i <= inputtedNumber) 
            {
                Console.Write(" * ");
            }
        }
    }
    Console.ResetColor();
} 