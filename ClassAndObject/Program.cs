Console.WriteLine("Class And Object");

//Person person = new ();  ---> New style init class in version 9.0
Person person = new Person();
Console.Write("Input first name: ");
person.FirstName = Console.ReadLine();
Console.Write("Input last name: ");
person.LastName = Console.ReadLine();
Console.Write("Input your year of birth: ");
person.YearOfBirth = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your salary: ");
double tempSalary = Convert.ToDouble(Console.ReadLine());
person.setSalary(tempSalary);
Console.WriteLine("---------------------------");
Console.WriteLine($"Your full name is: {person.fullName()}");
Console.WriteLine($"Your age is: {person.getAge()}");
Console.WriteLine($"Your salary is : {person.getSalary()}");
