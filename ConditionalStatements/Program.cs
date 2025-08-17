// See https://aka.ms/new-console-template for more information


/* Number1= Convert.ToInt32(Console.ReadLine());

Console.Write("Input your first number: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

*if (Number1 >= Number2)
{
    Console.WriteLine($"{Number1} > {Number2}");
}
else
{
    Console.WriteLine($"{Number1} < {Number2}");
}*

Console.WriteLine(
    Number1 > Number2 ? $"{Number1} > {Number2}" : 
    Number2 > Number1 ? $"{Number2} > {Number1}" : 
    $"{Number1} == {Number2}");

*/

Console.Write("Input your grade: ");
int myGrade = Convert.ToInt32(Console.ReadLine()); 
switch(myGrade)
{
    case int grade when grade < 5:
        Console.WriteLine("you failed the test");
        break;
    case int grade when grade >= 5 && grade < 8: 
        Console.WriteLine("you passed the test with good grade");
        break;
    case int grade when grade >= 8 && grade <= 10:
        Console.WriteLine("you passed the test with excelent grade");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;

}  