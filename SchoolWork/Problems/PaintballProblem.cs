using System.Runtime.InteropServices.ComTypes;

namespace SchoolWork;

public class PaintballProblem : Problem
{
public string Paintball(string[] playerName, int[][] scores)
{
    // Initialise teams
    var redTeam = new Dictionary<string, int>();
    var blueTeam = new Dictionary<string, int>();

    // organise the parameters into two dictionaries
    for (int i = 0; i < playerName.Length; i++)
    {
        if (scores[i][0] == 1)
            redTeam.Add(playerName[i], scores[i][1]);
        if (scores[i][0] == 0)
            blueTeam.Add(playerName[i], scores[i][1]);
    }

    var key = (KeyValuePair<string, int> keyValuePair) => keyValuePair.Value;

    var test =
        from player in redTeam
        where player.Value > 5
        select player;

    string redTeamTopScorer = redTeam.MaxBy(key).Key;
    string blueTeamTopScorer = blueTeam.MaxBy(key).Key;
    
    int redTeamTotalScore = redTeam.Sum(key);
    int blueTeamTotalScore = blueTeam.Sum(key);
    
    // find the winning team (team with the most points)
    var winningTeam = blueTeamTotalScore > redTeamTotalScore ? "blue" : "red";
    // check for a tie
    winningTeam = redTeamTotalScore == blueTeamTotalScore ? "Tie" : winningTeam;

    // format string and return
    return $@"
Winning Team                {winningTeam}
Red Team Total Score        {redTeamTotalScore}
Blue Team Total Score       {blueTeamTotalScore}
Highest Scorer in Red Team  {redTeamTopScorer}
Highest Scorer in Blue Team {blueTeamTopScorer}";
}
    public override void RunProblem()
    {
        
    }
}