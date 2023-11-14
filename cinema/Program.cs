string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cows = int.Parse(Console.ReadLine());   

int full = rows * cows; 
double income  = 0;
switch (type)
{
    case "Premiere":
        income = full * 12.00;
        break;
    case "Normal":
        income = full * 7.50;
        break;
    case "Discount":
        income = full * 5.00;
        break;
}
Console.WriteLine($"{income:F2} leva");