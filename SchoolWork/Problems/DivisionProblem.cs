namespace SchoolWork;

public class DivisionProblem
{

    public string Divide(int numerator, int denominator)
    {
        return numerator * denominator == 0 ? "E" : $"{numerator/denominator}";
    }
}