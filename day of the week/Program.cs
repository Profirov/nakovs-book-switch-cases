string fruit = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine(); 
double quantity = double.Parse(Console.ReadLine());

double price = 0;


if (dayOfTheWeek == "saturday" || dayOfTheWeek == "sunday")
{
    if (fruit == "banana") price = 2.70;
    else if (fruit == "apple") price = 1.25;
    else if (fruit == "orange") price = 0.90;
    else if (fruit == "grapefruit") price = 1.60;
    else if (fruit == "kiwi") price = 3.00;
    else if (fruit == "pineaple") price = 5.60;
    else if (fruit == "grapes") price = 4.20;
}
else if (dayOfTheWeek == "monday" || dayOfTheWeek == "tuesday" || dayOfTheWeek == "wednesday" || dayOfTheWeek == "thursday" || dayOfTheWeek == "friday")
{
    if (fruit == "banana") price = 2.50;
    else if (fruit == "apple") price = 1.20;
    else if (fruit == "orange") price = 0.85;
    else if (fruit == "grapefruit") price = 1.45;
    else if (fruit == "kiwi") price = 2.70;
    else if (fruit == "pineaple") price = 5.50;
    else if (fruit == "grapes") price = 3.85;

}
else
{
    Console.WriteLine("error");
}
double finalprice = price * quantity;
Console.WriteLine($"{finalprice:F2}");
