namespace Otus.NumbersSum.Services.SumCalculationStrategy;

public class ParallelSumCalculationStrategy : ISumCalculationStrategy
{
    public int Calculate(List<int> elements) => elements.AsParallel().Sum();
}   