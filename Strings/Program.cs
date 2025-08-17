string firstName;
string lastName;
string fullName;

Console.Write("Input your last name: ");
lastName = Console.ReadLine();

Console.Write("Input your first name: ");
firstName = Console.ReadLine();

fullName = lastName + " " + firstName;
Console.WriteLine($"Full name: {fullName}");
//Console.WriteLine(lastName + " " + firstName);
Console.WriteLine("Display like varible in array {0} {1}", lastName, firstName);

//Length
Console.WriteLine($"Last name length: {lastName.Length}");
Console.WriteLine($"First name length: {firstName.Length}");
Console.WriteLine($"Full name length: {fullName.Length}");

//Replace 
string newLastName = lastName.Replace("Tran", "Tran Si");
Console.WriteLine($"New last name: {newLastName}");

//Spilit
string[] spilitName = fullName.Split(' ');
foreach(string name in  spilitName)
{
    Console.WriteLine($"Name: {name}");
}

//Conpare String

if (firstName.Equals(lastName, StringComparison.InvariantCultureIgnoreCase))
{
    Console.WriteLine("First and last name are same");
}
else
{
    Console.WriteLine("First and last name are not same");
}

Console.WriteLine($"Upper Case: {fullName.ToUpper()}");
Console.WriteLine($"Lower Case: {fullName.ToLower()}");