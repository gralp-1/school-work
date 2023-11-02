using System.Xml.Serialization;

namespace SchoolWork;

public class GamerTagProblem : Problem
{
    private class Player
    {
        [XmlAttribute] public string email { get; set; }
        [XmlAttribute] public string gamerTag { get; set; }
    }
    private void GamerTag()
    {
        // load the gamerTagDatabase.xml file
        // if it doesn't exist, create it
        XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
        if (!File.Exists("./gamerTagDatabase.xml"))
        {
            File.Create("./gamerTagDatabase.xml");
        }
        var players = (List<Player>) serializer
            .Deserialize(File.OpenRead("./gamerTagDatabase.xml"));
        Console.WriteLine("Enter email:");
        string email = Console.ReadLine();
        Console.WriteLine("Enter gamer tag:");
        string gamerTag = Console.ReadLine();
        if (players.Any(p => p.email == email || p.gamerTag == gamerTag))
        {
            Console.WriteLine("Player with this email/gamer tag already exists");
        }
        else
        {
            players.Add(new Player {email = email, gamerTag = gamerTag});
            serializer.Serialize(File.OpenWrite("./gamerTagDatabase.xml"), players);
        }
    }
    public override void RunProblem()
    {
        GamerTag();
    }
}