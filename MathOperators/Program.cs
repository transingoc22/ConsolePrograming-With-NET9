// See https://aka.ms/new-console-template for more information

int myNum1 = 10;
int myNum2 = 20;

Console.WriteLine($"Additional: {myNum1 + myNum2} "); //30
Console.WriteLine($"Subtraction : {myNum1 - myNum2} "); // -10
Console.WriteLine($"Multiple : {myNum1 * myNum2} "); // 200
Console.WriteLine($"Divide : {myNum1 / myNum2} "); // 0
Console.WriteLine($"Modulus : {myNum1 % myNum2} "); // 10


myNum1 = 10 + 5;
Console.WriteLine($"New value of myNum1: {myNum1}"); //15
Console.WriteLine($"Additional: {myNum1 + myNum2} "); //35
Console.WriteLine($"Subtraction : {myNum1 - myNum2} "); //-5
Console.WriteLine($"Multiple : {myNum1 * myNum2} "); //300
Console.WriteLine($"Divide : {myNum1 / myNum2} "); //0
Console.WriteLine($"Modulus : {myNum1 % myNum2} "); //15


//myNum2 += 4;
//myNum2 -= 4;
//myNum2 *= 4;
//myNum2 /= 4;
myNum2 %= 4;
Console.WriteLine($"myNum2 value: {myNum2}");