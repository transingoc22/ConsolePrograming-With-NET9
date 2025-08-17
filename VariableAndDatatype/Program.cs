//Variable Declarations and Type


using System.Globalization;

string fullName = string.Empty;
int age;
double height;
double weight;

Console.Write("Input your fullname: ");
fullName = Console.ReadLine();
Console.Write("Input your age: ");
age = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input your height (m): ");
height = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Input your weight (kg): ");
weight = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("-------------Print Information-------------");
Console.WriteLine("Your name: " +  fullName);
Console.WriteLine("Your age: " + age);
Console.WriteLine("Your height: " + height + " m");
Console.WriteLine("Your weight: " + weight + " kg");

Console.WriteLine("-------------Print Information-------------");
Console.WriteLine($"Your name: {fullName}" );
Console.WriteLine($"Your age: {age}");
Console.WriteLine($"Your height: {height} m");
Console.WriteLine($"Your weight: {weight} kg");
