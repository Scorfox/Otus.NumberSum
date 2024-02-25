namespace Otus.NumbersSum.Services.SumCalculationStrategy;

public class ThreadSumCalculationStrategy : ISumCalculationStrategy
{
    public int Calculate(List<int> elements)
    {
        var sum = 0;
        var numberOfThreads = 5;
        var threads = new List<Thread>();
        var lockObject = new object();

        for (var i = 0; i < numberOfThreads; i++)
        {
            var start = elements.Count / numberOfThreads * i;
            var end = elements.Count / numberOfThreads * (i + 1);
            var thread = new Thread(() =>
            {
                var localSum = 0;
                
                for (var j = start; j < end; j++)
                    localSum += elements[j];
                
                lock(lockObject)
                    sum += localSum;
            });
            threads.Add(thread);
        }
        
        foreach (var t in threads)
            t.Start();
        
        foreach (var thread in threads)
            thread.Join();
        
        return sum;
    }
}