namespace SchoolWork;

public class QuoteProblem
{
    public (string,string) QuoteOfTheDay()
    {
        string[,] quotes = new string[2,3];
        
        quotes[0, 0] = "Any fool can write code that a computer can understand. Good programmers write code that humans can understand.";
        quotes[0, 1] = "Martin Fowler";
        
        quotes[1, 0] = "Code is like humor. When you have to explain it, it’s bad.";
        quotes[1, 1] = "Cory House";
        
        quotes[2, 0] = "Simplicity is the soul of efficiency.";
        quotes[2, 1] = "Austin Freeman";

        int i = new Random().Next(0, 3);
        return (quotes[i,0], quotes[i,1]);
    }
}