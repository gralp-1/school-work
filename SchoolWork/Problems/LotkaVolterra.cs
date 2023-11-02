namespace SchoolWork;

public class LotkaVolterra
{
    public static string PredatorPrey(int predators, int prey, float A, float B, float C, float D)
    {
        // CSV header
        var res = "gen,pred,prey\n";
        // 1st gen is gen zero
        int gen = 0;
        while (gen != 200)
        {
            // add the current generation's data to the csv
            res += $"{gen},{predators},{prey}\n";
            
            // calculate the next generation
            float preyGrowth = float.Pow(float.E, A - C * predators);
            prey = (int)(prey * preyGrowth);
            
            float predatorGrowth = float.Exp(D * C * prey - B);
            predators = (int)(predators * predatorGrowth);
            
            // increment the generation
            gen++;
        }
        // return the csv text
        return res;
    }
}