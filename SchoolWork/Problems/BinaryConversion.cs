namespace SchoolWork;

public class BinaryConversion
{
    public string BinaryFromInt(int input)
    {
        string res = "";
        double copy = input;
        while (copy != 0)
        {
            // prepend
            res = copy % 2 + res;
            copy /= 2;
            copy = double.Floor(copy);
        }
        return res;
    }
}