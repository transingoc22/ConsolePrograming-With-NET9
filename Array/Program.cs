


//int myLength = 0;
//Console.Write("Input your array length: ");
//myLength = Convert.ToInt32(Console.ReadLine());

//int[] myGrades = new int[myLength];

////Input value for array
//for  (int i = 0; i < myGrades.Length; i++)
//{
//    Console.Write($"Input value {i}:  ");
//    myGrades[i] = Convert.ToInt32(Console.ReadLine());
//}

////Display value of array
//for (int i = 0; i < myGrades.Length; i++)
//{
//    Console.WriteLine($"Index {i}: {myGrades[i]}");
//}

int myLength = 0;
Console.Write("Input your array length: ");
myLength = Convert.ToInt32(Console.ReadLine());
string[] myStudentName = new string[myLength];

//input Student Name
for (int i = 0; i < myStudentName.Length; i++)
{
    Console.Write($"Input value {i}: ");
    myStudentName[i] = Console.ReadLine();
}

//Display value of array
for (int i = 0; i < myStudentName.Length; i++)
{
    Console.WriteLine($"Index {i}: {myStudentName[i]}");
}