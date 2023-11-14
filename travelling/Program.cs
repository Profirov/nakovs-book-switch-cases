decimal budget = decimal.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destinationResult = string.Empty;
string holidayInformation = string.Empty;
decimal moneySpend = 0.00M;

if (budget <= 100.00M)
{
    destinationResult = "Bulgaria";
    if (season.Equals("summer"))
    {
        moneySpend = 0.30M * budget;
        holidayInformation = string.Format($"Camp - {moneySpend:F2}");
    }
    else
    {
        moneySpend = 0.70M * budget;
        holidayInformation = string.Format($"Hotel - {moneySpend:F2}");
    }
}
else if (budget <= 1000.00M)
{
    destinationResult = "Balkans";
    if (season.Equals("summer"))
    {
        moneySpend = 0.40M * budget;
        holidayInformation = string.Format($"Camp - {moneySpend:F2}");
    }
    else
    {
        moneySpend = 0.80M * budget;
        holidayInformation = string.Format($"Hotel - {moneySpend:F2}");
    }
}
else
{
    destinationResult = "Europe";
    moneySpend = 0.90M * budget;
    holidayInformation = string.Format($"Hotel - {moneySpend:F2}");
}
Console.WriteLine($"Somewhere in {destinationResult}");
Console.WriteLine(holidayInformation);