Console.Write("Input height: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.Write("Input length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input width: ");
int width = Convert.ToInt32(Console.ReadLine());

Cube cube = new Cube (height, length, width);

Console.WriteLine($"Area: {cube.getArea()}");
Console.WriteLine($"Volumne: {cube.getVolume()}");