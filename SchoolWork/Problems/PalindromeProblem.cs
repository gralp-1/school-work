namespace SchoolWork;

public class PalindromeProblem : Problem
{
    private static bool IsLetterOrNumber(char c)
    {
        return char.IsLetter(c) || char.IsNumber(c);
    }

    public static bool IsPalindrome(string text)
    {
        // strip it down to just lowercase letters
        string filtered = new string(
                text
                    .Where(IsLetterOrNumber)
                    .ToArray())
            .ToLower();
        if (filtered.Length == 0)
            return false;
        for (int i = 0; i < filtered.Length - 1; i++)
        {
            // get the index from the opposite end of the string
            int oppositeIndex = filtered.Length - i - 1;
            // if the characters don't match then it's not a palindrome
            if (filtered[i] != filtered[oppositeIndex])
            {
                return false;
            }
        }

        // if it hasn't already exited false then it must be true
        return true;
    }

    public override void RunProblem()
    {
        Console.WriteLine(IsPalindrome("123454321"));
        string[] cases = """
                         bob
                         anna
                         ANNA
                         Anna
                         CRAIG
                         craig
                         Craig
                         Dave
                         King are you glad you are king
                         Borrow or rob
                         Hello World
                         123454321
                         12344321
                         """.Trim().Split('\n');
        bool[] expected =
        {
            true,
            true,
            true,
            true,
            false,
            false,
            false,
            false,
            false,
            true,
            false,
            true,
            true,
        };
        if (expected.Length != cases.Length)
        {
            Console.WriteLine("Case-expected length mismatch");
            return;
        }

        for (int i = 0; i < cases.Length; i++)
        {
            string c = cases[i];
            bool e = expected[i];
            bool res = IsPalindrome(c);
            if (res != e)
            {
                Console.WriteLine($"Case {c} failed, expected {e} but got {res}");
            }
            else
            {
                Console.WriteLine($"Case {c} passed");
            }
        }
    }
}