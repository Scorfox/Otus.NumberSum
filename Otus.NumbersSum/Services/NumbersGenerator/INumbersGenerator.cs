namespace Otus.NumbersSum.Services.NumbersGenerator;

public interface INumbersGenerator
{
    List<int> Generate(int count, int min, int max);
}