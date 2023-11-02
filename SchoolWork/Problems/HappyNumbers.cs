namespace SchoolWork;

public class HappyNumbers
{

    public bool IsHappyNumber(int number)
    {
        while (true)
        {
            var digits = number
                .ToString() // convert number into a list of digits
                .Select(t=>int.Parse(t.ToString())); 
            number = digits
                .Select(x => x*x) // square all digits
                .Sum(); // sum these digits
            if(number == 4) // break case
                return false;
            if(number == 1) // happy number iteration always ends in 1
                return true;
        }
    }
}