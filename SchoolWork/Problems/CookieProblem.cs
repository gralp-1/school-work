namespace SchoolWork;

public class CookieProblem
{
    public void Cookies()
    {
        // check if the file "cookie.txt" exists
        string path = "cookie.txt";
        string cookie = "";
        if (File.Exists("cookie.txt"))
        {
            cookie = File.ReadAllLines(path)[0];
        }
        Console.WriteLine($"Current dark mode preference preference: {cookie}");
        
        Console.WriteLine("Update preference to: [true/false]");
        switch (Console.ReadLine())
        {
            case "true":
                File.WriteAllText(path, "true");
                break;
            case "false":
                File.WriteAllText(path, "false");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}