namespace Otus.NumbersSum.Services.NumbersGenerator;

public class NumbersGenerator : INumbersGenerator
{
    public List<int> Generate(int count, int min, int max)
    {
        var randomNumbers = new List<int>();
        var random = new Random();
        
        for (var i = 0; i < count; i++)
            randomNumbers.Add(random.Next(min, max));

        return randomNumbers;
    }
}