namespace SchoolWork;
using System;
public class DiceProb : Problem
{
    public static void OutputFive()
    {
    string diceSide = @"
ooooooooooo
o         o
o  #   #  o
o    #    o
o  #   #  o
o         o
ooooooooooo";
    Console.WriteLine(diceSide);
    }

    public override void RunProblem()
    {
        OutputFive();
    }
}