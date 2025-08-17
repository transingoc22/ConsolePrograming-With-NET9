using System;
using System.Security.Cryptography;

//int FindHighestNumber(int number1, int number2, int number3, int number4)
//{
//    /*int highest = (number1 > number2)
//          ? (number1 > number3 ? number1 : number3)
//          : (number2 > number3 ? number2 : number3);
//      return highest;
//    */

//    int highest = Math.Max(Math.Max(number1, number2), Math.Max(number3, number4)); 
//    return highest;
//}

//int number1, number2, number3, number4;
//Console.Write("Input your number 1: ");
//number1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input your number 2: ");
//number2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input your number 3: ");
//number3 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input your number 4: ");
//number4 = Convert.ToInt32(Console.ReadLine());

//int highest = FindHighestNumber(number1, number2, number3, number4);

//Console.WriteLine($"Highest number: {highest}");

int FindMax(params int[] numbers)
{
    return numbers.Max();
}

int number1, number2, number3, number4;
Console.Write("Input your number 1: ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your number 2: ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your number 3: ");
number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your number 4: ");
number4 = Convert.ToInt32(Console.ReadLine());

int max = FindMax(number1, number2, number3, number4);
Console.WriteLine($"Max is: {max}");