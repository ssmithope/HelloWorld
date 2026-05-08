//Console.WriteLine("Hello, World!");

string name = "Smith";
Console.WriteLine($"Hello, {name}! Welcome to .NET.");

DateTime now = DateTime.Now;
Console.WriteLine($"The current time is {now}.");

// If Christmas already passed this year, use next year
DateTime today = DateTime.Today;
DateTime christmas = new DateTime(today.Year, 12, 25);

if (today > christmas)
{
    christmas = christmas.AddYears(1);
}

int daysUntil = (christmas - today).Days;

Console.WriteLine($"There are {daysUntil} days until next Christmas.");
