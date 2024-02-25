namespace Otus.NumbersSum.Services.SumCalculationStrategy;

public class OrdinarySumCalculationStrategy : ISumCalculationStrategy
{
    public int Calculate(List<int> elements) => elements.Sum();
}