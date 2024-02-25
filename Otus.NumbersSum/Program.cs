// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Otus.NumbersSum.Services.NumbersGenerator;
using Otus.NumbersSum.Services.SumCalculationStrategy;

var stopwatch = new Stopwatch();

var ordinarySumCalculationStrategy = new OrdinarySumCalculationStrategy();
var parallelSumCalculationStrategy = new ParallelSumCalculationStrategy();
var threadSumCalculationStrategy = new ThreadSumCalculationStrategy();
var numbersGenerator = new NumbersGenerator();
var numbers = numbersGenerator.Generate(10_000_000, 1, 5);

stopwatch.Start();
var ordinarySumCalculationStrategyResult = ordinarySumCalculationStrategy.Calculate(numbers);
stopwatch.Stop();

Console.WriteLine($"OrdinarySumCalculationStrategyResult: {ordinarySumCalculationStrategyResult}. " +
                  $"Elapsed seconds: {stopwatch.Elapsed.TotalSeconds}");

stopwatch.Restart();
var parallelSumCalculationStrategyResult = parallelSumCalculationStrategy.Calculate(numbers);
Console.WriteLine($"ParallelSumCalculationStrategyResult: {parallelSumCalculationStrategyResult}. " +
                  $"Elapsed seconds: {stopwatch.Elapsed.TotalSeconds}");
stopwatch.Stop();

stopwatch.Restart();
var threadSumCalculationStrategyResult = threadSumCalculationStrategy.Calculate(numbers);
Console.WriteLine($"ThreadSumCalculationStrategyResult: {threadSumCalculationStrategyResult}. " +
                  $"Elapsed seconds: {stopwatch.Elapsed.TotalSeconds}");
stopwatch.Stop();

Console.WriteLine($"Numbers count: {numbers.Count}");