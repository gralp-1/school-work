namespace SchoolWork;

public class DaysOfChristmas
{
    public void TwelveDaysOfChristmas()
    {

        string[] days = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh",
            "eighth", "ninth", "tenth", "eleventh", "twelfth" };
        
        string[] gifts = { "A partridge in a pear tree", "Two turtle doves", "Three french hens",
            "Four calling birds", "Five golden rings", "Six geese a-laying", "Seven swans a-swimming",
            "Eight maids a-milking", "Nine ladies dancing", "Ten lords a-leaping", "Eleven pipers piping",
            "Twelve drummers drumming" };

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"On the {days[i]} day of Christmas my true love gave to me:");
            for (int j = i; j >= 0; j--)
            {
                Console.WriteLine(gifts[j]);
            }
            Console.WriteLine();
            
        }
    }
}