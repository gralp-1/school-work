namespace SchoolWork;

public class GreenBottlesProblem : Problem
{
    private string GreenBottles(int bottles)
    {
        var isPlural = (int n) => n > 1 ? "s" : "";
        string res = "";
        for (int i = bottles; i >= 0; i--)
        {
            res += $@"
{i} green bottle{isPlural(i)} hanging on the wall,
{i} green bottle{isPlural(i)} hanging on the wall,
And if one green bottle should accidentally fall,
There'll be {i - 1} bottle{isPlural(i)} hanging on the wall.";
        }

        return res;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}