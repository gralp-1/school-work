using System.Globalization;

namespace SchoolWork;

public class TimeSheetProblem : Problem
{
    private void TimeSheet()
    {
        Console.WriteLine("Enter day dd/mm:");
        var day = Console.ReadLine();
        Console.WriteLine("Enter hours:");
        var hours = Console.ReadLine();
        var month = DateTime
            .ParseExact(day, "dd/mm", CultureInfo.InvariantCulture)
            .ToString("MMMM");
        var year = DateTime.Now.Year.ToString();
        var fPath = $"./{year}/{month}.txt";
        File.Create(fPath);
        
        int monthsHours = 0;
        try
        {
            monthsHours = int.Parse(File.ReadAllText(fPath));
            monthsHours += int.Parse(hours);
        }
        catch {}
        File.WriteAllText(fPath, monthsHours.ToString());
        Console.WriteLine($"Hours for month: {monthsHours}");
    }
    public override void RunProblem()
    {
        TimeSheet();
    }
}