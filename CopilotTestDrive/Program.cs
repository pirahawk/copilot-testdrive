// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int firstNumber, secondNumber;

Console.Write("Enter the first integer: ");
while (!int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.Write("Invalid input. Please enter a valid integer: ");
}

Console.Write("Enter the second integer: ");
while (!int.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.Write("Invalid input. Please enter a valid integer: ");
}

try
{
    int result = MyMathHelper.AddWithOverflowCheck(firstNumber, secondNumber);
    Console.WriteLine($"The sum is: {result}");
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}