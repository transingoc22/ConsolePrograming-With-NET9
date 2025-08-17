
using System.Globalization;

DateTime myBirthDay = new DateTime(1996, 01, 04);
Console.WriteLine($"My birthday is: {myBirthDay}" );
Console.WriteLine("My birthday is: " + myBirthDay);

DateTime now =  DateTime.Now;
Console.WriteLine(now);

//Create datetime from string
DateTime fromString1 = DateTime.Parse("1996/01/04", CultureInfo.CurrentCulture);
Console.WriteLine("Date from string1: " + fromString1);
DateTime fromString2 = DateTime.Parse("1996/01/04", CultureInfo.InvariantCulture);
Console.WriteLine("Date from string1: " + fromString2);


//Additonal Time
Console.WriteLine("Add 1 hour: " + now.AddHours(1));
Console.WriteLine("Add 1 day: " + now.AddDays(1));
Console.WriteLine("Add 1 month: " + now.AddMonths(1));
Console.WriteLine("Add 1 year: " + now.AddYears(1));


//Ticks from DateTime
Console.WriteLine("Ticks: " + now.Ticks);


//Date Only
DateOnly dateOnly = DateOnly.FromDateTime(myBirthDay);
Console.WriteLine("DateOnly: " + dateOnly);

//Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(myBirthDay);
Console.WriteLine("TimeOnly: " + timeOnly);



//Display Day, Month, Yeah from birthy
Console.WriteLine("Day: {0}", myBirthDay.Day);
Console.WriteLine("Month: {0}", myBirthDay.Month);
Console.WriteLine("Year: {0}", myBirthDay.Year);

Console.WriteLine("Day: " + myBirthDay.Day);
Console.WriteLine("Month: " + myBirthDay.Month);
Console.WriteLine("Year: " + myBirthDay.Year);

Console.WriteLine($"Day: {myBirthDay.Day}");
Console.WriteLine($"Month: {myBirthDay.Month}");
Console.WriteLine($"Year: {myBirthDay.Year}" );