int examHours = int.Parse(Console.ReadLine());
int examMinutes  = int.Parse(Console.ReadLine());
int arrivalsHours  = int.Parse(Console.ReadLine());
int arrivalsMinutes  = int.Parse(Console.ReadLine());

string late = "Late";
string onTime = "On time";
string early = "Early";
int examTime = (examHours * 60) + examMinutes;
int arrivalTime = (arrivalsHours * 60) + arrivalsMinutes;
int totalMinutesDifferent = arrivalTime - examTime;
string studentArrival = late;
if (totalMinutesDifferent < -30)
{
    studentArrival = early;
}
else if (totalMinutesDifferent <= 30)
{
    studentArrival = onTime;
}
string result = string.Empty;
if (totalMinutesDifferent != 0)
{ 
int hoursDifference = Math.Abs(totalMinutesDifferent/60);
    int minutesDifference = Math.Abs(totalMinutesDifferent%60);
    if (hoursDifference > 0)
    {
        result = string.Format($"{hoursDifference}:{minutesDifference} hours");
    }
    else
    {
        result = minutesDifference + " minutes";
    }
    if (hoursDifference < 0)
    {
        result += " before the start";
    }
    else
    {
        result += " after the start";
    }
}
Console.WriteLine(studentArrival);
if (!string.IsNullOrEmpty(result))
{
    Console.WriteLine(result);
}

