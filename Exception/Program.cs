Console.WriteLine("Exception");

int number1, number2;

Console.Write("Input number 1: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
number2 = Convert.ToInt32(Console.ReadLine());
try
{
    int result = number1 / number2;
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divided by 0");
}
finally
{
    Console.WriteLine("Final of try catch");
}