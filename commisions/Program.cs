string nameoftheTown = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double commission = 0;
double finall = sales * commission;
if (nameoftheTown == "sofia")
{
    if (0 <= sales && sales <= 500) commission = 0.05;
    else if (500 < sales && sales <= 100) commission = 0.07;
    else if (100 < sales && sales <= 10000) commission = 0.08;
    else if (sales > 10000) commission = 0.12;
}
else if (nameoftheTown == "varna")
{
    if (0 <= sales && sales <= 500) commission = 0.045;
    else if (500 < sales && sales <= 100) commission = 0.075;
    else if (100 < sales && sales <= 10000) commission = 0.10;
    else if (sales > 10000) commission = 0.13;
}
else if (nameoftheTown == "plovdiv")
{
    if (0 <= sales && sales <= 500) commission = 0.055;
    else if (500 < sales && sales <= 100) commission = 0.08;
    else if (100 < sales && sales <= 10000) commission = 0.12;
    else if (sales > 10000) commission = 0.145;
}


   
else if (nameoftheTown !="sofia" &&  nameoftheTown != "plovdiv" &&  nameoftheTown != "varna")
{
    Console.WriteLine("error");
}

Console.WriteLine($"{finall:F2}");



