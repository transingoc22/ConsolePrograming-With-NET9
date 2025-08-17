// See https://aka.ms/new-console-template for more information
//Loop statements

/*for (int i = 0; i <= 10; i ++)
{
    Console.WriteLine($"I'm in loop: {i}");
} */

//While statemeents


/* while (n <= 5)
{
    Console.WriteLine("----------------- ");
    Console.Write("Input your number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your input number is: {n}");
}*/


int i = 0;
Console.Write("Input your number: ");
i = Convert.ToInt32(Console.ReadLine());

while (i < 3)
{
    Console.WriteLine($"I number value: {i}");
    i++;
}

//Do while statements
//int i = 0;
//Console.Write("Input your number: ");
//i = Convert.ToInt32(Console.ReadLine());
//do
//{
//    Console.WriteLine($"I number value: {i}");
//    i++;
//} while (i < 3);

