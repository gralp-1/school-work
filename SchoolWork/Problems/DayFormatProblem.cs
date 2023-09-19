
namespace SchoolWork;

public class DayFormatProblem : Problem
{
    private static string DayFormat(int dayNumber, string format)
    {
        // check the dayNumber parameter to see if it's valid
        if (!Enumerable.Range(1, 7).Contains(dayNumber))
            throw new ArgumentException("Day number invalid, must be between 1 and 7 inclusive");
        // get the name of the current day
        string day = new List<string>{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}[dayNumber-1];
        // apply format
        switch (format.ToLower())
        {
            case "day":
            {
                return day;
            }
            case "shortday":
            {
                return day[..3];
            }
            case "char":
            {
                return day[..2];
            }
        }
        // if it breaks out of the case then it's an invalid argument
        throw new ArgumentException("String format must be \"day\", \"shortday\" or \"char\"");
    }
    public override void RunProblem()
    {
        int dayNumber = 3;
        string format = "shortday";
        Console.WriteLine($"Day {dayNumber} in {format} format is {DayFormat(3, "shortday")}");
    }
}