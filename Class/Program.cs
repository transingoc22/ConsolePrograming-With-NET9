using ClassProject;

Person person = new ();
Console.Write("Input your first name: ");
person.firstName = Console.ReadLine();
Console.Write("Input your middle name: ");
person.middleName = Console.ReadLine();
Console.Write("Input your last name: ");
person.lastName = Console.ReadLine();
Console.Write("Input your year birth: ");
person.yearBirth = Convert.ToInt32(Console.ReadLine());
person.setSalary();
Console.Write("Input your graduated year: ");
int number = Convert.ToInt32(Console.ReadLine());

if (string.IsNullOrEmpty(person.middleName))
{
    Console.WriteLine("---------Your Information-------------");
    Console.WriteLine($"Your full name: {person.fullName(person.firstName, person.lastName)}");
    Console.WriteLine($"Your age : {person.yourAge()}");
    Console.WriteLine($"Your salary: {person.getSalary()}");
    Console.WriteLine($"Your working experience years: {DateUtil.graduatedYear(number)} years");
}
else
{
    Console.WriteLine("---------Your Information-------------");
    Console.WriteLine($"Your full name: {person.fullName(person.firstName, person.middleName,  person.lastName)}");
    Console.WriteLine($"Your age : {person.yourAge()}");
    Console.WriteLine($"Your salary: {person.getSalary()}");
    Console.WriteLine($"Your working experience years: {DateUtil.graduatedYear(number)} years");
}