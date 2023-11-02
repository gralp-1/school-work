namespace SchoolWork;

public class ShoppingListProblem : Problem
{
    private string path;
    private int AddItem()
    {
        Console.WriteLine("Enter item:");
        string item = Console.ReadLine();
        // read the file, append this to the file on a new line
        File.AppendAllText(path, item + "\n");
        return 0;
    }

    private int ViewItems()
    {
        Console.WriteLine(File.ReadAllText(path));
        return 0;
    }

    private int RemoveItem()
    {
        List<string> items = File.ReadLines(path).ToList();
        Console.WriteLine("Enter item to remove:");
        string item = Console.ReadLine();
        if (items.Contains(item))
        {
            items.Remove(item);
            File.WriteAllLines(path, items);
            return 0;
        }
        Console.WriteLine("Item not found");
        return 1;
    }
    private void ShoppingList()
    {
        path = Console.ReadLine();
        if (path == null)
        {
            Console.WriteLine("Invalid path");
            return;
        }
        if (!File.Exists(path))
        {
            File.Create(path);
        }
        Dictionary<string, Func<int>> actions = new();
        actions.Add("add", AddItem);
        actions.Add("remove", RemoveItem);
        actions.Add("view", ViewItems);

        do
        {
            Console.WriteLine("Add/Remove/View/Quit");
            string? res = Console.ReadLine();
            if (res == null)
            {
                Console.WriteLine("Invalid response");
                continue;
            }

            if (res.ToLower() == "quit")
            {
                break;
            }

            int code = actions[res]();
            if (code!=0) Console.WriteLine($"Function returned error code {code}");
        } while (true);
    }

    public override void RunProblem()
    {
        ShoppingList();
    }
}