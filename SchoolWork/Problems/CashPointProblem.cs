using System.Diagnostics;

namespace SchoolWork;

public class CashPointProblem
{
    public int Notes(int amount)
    {
        int amountOfNotes = 0;
        while (amount != 0)
        {
            // probably a cleaner list-based
            // implementation
            amount -= amount switch
            {
                > 20 => 20,
                > 10 => 10,
                > 5 => 5
            };

            amountOfNotes++;
        }
        return amountOfNotes;
    }
}