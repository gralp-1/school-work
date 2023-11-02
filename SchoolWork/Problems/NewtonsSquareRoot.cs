namespace SchoolWork;

public class NewtonsSquareRoot
{
    public double Sqrt(int input)
    {
        double root = input;
        double oldRoot = input+1;
        while(!oldRoot.Equals(root))
        {
            oldRoot = root;
            root = 0.5 * (root + input / root);
        }

        return root;
    }
}