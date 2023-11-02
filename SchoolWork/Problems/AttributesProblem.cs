namespace SchoolWork;

public class AttributesProblem
{
    public void SaveAttributes()
    {
        Console.WriteLine("Enter character name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter character defence (1 to 100)");
        var defence = Console.ReadLine();
        Console.WriteLine("Enter character attack  (1 to 100)");
        var attack = Console.ReadLine();
        var file = File.Open($"{name}.player", FileMode.Create);
        // check attack and defence are both integers in the range
        if (int.TryParse(defence, out var def) 
            && int.TryParse(attack, out var att) 
            && Enumerable.Range(1,100).Contains(def)
            && Enumerable.Range(1,100).Contains(att))
        {
            var writer = new BinaryWriter(file);
            writer.Write(def);
            writer.Write(att);
            writer.Close();
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}