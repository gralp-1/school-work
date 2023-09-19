namespace SchoolWork;

public class CurrencyConverterProblem : Problem
{
    private Dictionary<string, double> _conversionDict;
    public CurrencyConverterProblem()
    {
        _conversionDict = new Dictionary<string, double>();
        // add all of our conversion rates at class construction time
        _conversionDict.Add("eur", 1.16);
        _conversionDict.Add("usd", 1.24);
        _conversionDict.Add("rmb", 9.04);
        _conversionDict.Add("jpy", 183.0);
    }
    private double CurrenctConverter(double pounds, string code)
    {
        return pounds * _conversionDict[code];
    }

    public override void RunProblem()
    {
        var code = "rmb";
        var amount = 150.0;
        Console.WriteLine($"{amount:C} is {CurrenctConverter(amount, code)} {code}");
    }
}