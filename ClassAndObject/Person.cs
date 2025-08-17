public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
    private double Salary { get; set; }

    public void setSalary(double tempSalary)
    {
        Salary = tempSalary;
    }

    public double getSalary()
    {
        return Salary;
    }

    public string fullName()
    {
        return FirstName + " " + LastName;
    }

    public int getAge()
    {
        return DateTime.Now.Year - YearOfBirth;
    }
}