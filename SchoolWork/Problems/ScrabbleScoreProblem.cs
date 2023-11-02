namespace SchoolWork;

public class ScrabbleScoreProblem : Problem
{
    private int ScrabbleScore(string word)
    {
        var scores = new Dictionary<string, int>();
        scores.Add("eaionrtlsu", 1);
        scores.Add("dg",         2);
        scores.Add("bcmp",       3);
        scores.Add("fhvwy",      4);
        scores.Add("k",          5);
        scores.Add("jx",         8);
        scores.Add("qz",         10);
        return 
            (from character in word
                from key in scores.Keys
                where key.Contains(character.ToString().ToLower())
                select scores[key])
            .Sum();
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}