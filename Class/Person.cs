// See https://aka.ms/new-console-template for more information
class Person
{
    public string firstName { get; set; }
    public string middleName { get; set; }
    public string lastName { get; set; }
    public int yearBirth { get; set; }
    private double salary { get; set; }

    public void setSalary()
    {
        Console.Write("Input your salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
    }
    public double getSalary()
    {
        return salary;
    }
    public string fullName(string firstName, string lastName) 
    {
        return firstName + " " + lastName;
    }
    public string fullName(string firstName, string middleName, string lastName)
    {
        return firstName + " " + middleName + " " + lastName;
    }
    public int yourAge ()
    {
        return DateTime.Now.Year - yearBirth;
    }

}

