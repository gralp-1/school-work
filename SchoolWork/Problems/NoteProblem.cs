namespace SchoolWork;

public class NoteProblem
{
    string[] notes = new string[10];

    private void PrintNotes()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i}: {notes[i]}");
        }
    }
    
    public void Notebook()
    {
        string input;
        while(true)
        {
            PrintNotes();
            Console.WriteLine("Enter note to change:");
            input = Console.ReadLine();
            if (input == "quit")
                break;
            int index = int.Parse(input);
            Console.WriteLine("Enter new note:");
            notes[index] = Console.ReadLine();

        }
    }
}