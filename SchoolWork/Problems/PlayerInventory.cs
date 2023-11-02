namespace SchoolWork;

public class PlayerInventory
{
    private List<string> _inventory;

    public PlayerInventory(List<string> inventory)
    {
        _inventory = inventory;
    }

    public void Drop(string item)
    {
        _inventory.Remove(item);
    }

    public void Pull()
    {
        int i = new Random().Next(0, _inventory.Count);
        Console.WriteLine($"You picked up {_inventory[i]}");
    }

    public void Pick(string newItem)
    {
        _inventory.Add(newItem);
    }

    public void Search()
    {
        _inventory.ForEach(Console.WriteLine);
    }
}