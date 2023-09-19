namespace SchoolWork;

public class ExamGradeProblem : Problem
{
    private static bool InRange((int, int) range, int input)
    {
        return input <= range.Item2 & input >= range.Item1;
    }
    private static string ExamGrade(int mark)
    {
        var ranges = new Dictionary<(int, int), int>();
        // add all the grade boundaries
        ranges.Add((2,2),   1);
        ranges.Add((3,12),  2);
        ranges.Add((13,21), 3);
        ranges.Add((21,30), 4);
        ranges.Add((31,40), 5);
        ranges.Add((41,53), 6);
        ranges.Add((54,66), 7);
        ranges.Add((67,79), 8);
        ranges.Add((80,int.MaxValue),   9);
        
        
        foreach (var (markRange, resultantGrade) in ranges)
        {
            if (InRange(markRange, mark))
            {
                return resultantGrade.ToString();
            }
        }
        // if it's not in these ranges it's a U (mark is less than 2
        return "U";
    }
    public override void RunProblem()
    {
        const int mark = 30;
        Console.WriteLine($"{mark} marks is a grade {ExamGrade(mark)}");
    }
}