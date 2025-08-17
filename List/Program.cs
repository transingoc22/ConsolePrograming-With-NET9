List<string> myListName = new List<string>();
Console.Write("Input length: ");
int length = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < length; i++)
{
    while (true)
    {
        Console.Write($"Input student name {i + 1}: ");
        string tempName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tempName))
        {
            Console.WriteLine("Invalid name or name cannot be empty, please try again.");
        }
        else
        {
            myListName.Add(tempName);
            break;
        }
    }
}
//display via for
//for (int i = 0; i < myListName.Count; i++)
//{
//    Console.WriteLine($"myListName[{i}]: {myListName[i]}");
//}

//display via foreach
foreach (string items in myListName)
{
    Console.WriteLine($"{items}");
}    