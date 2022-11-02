using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

namespace Learn
{
    /*
     * BenchmarkDotNet is a lightweight, open source, powerful .NET library that can transform your methods into benchmarks,
     * track those methods, and then provide insights into the performance data captured.
     */

    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Benchmarker
    {
        int NumberOfItems = 100000;

        [Benchmark(Baseline = true)]
        public string ConcatStringsUsingStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < NumberOfItems; i++)
            {
                sb.Append("Hello World!" + i);
            }
            return sb.ToString();
        }

        [Benchmark]
        public string ConcatStringsUsingGenericList()
        {
            var list = new List<string>(NumberOfItems);
            for (int i = 0; i < NumberOfItems; i++)
            {
                list.Add("Hello World!" + i);
            }
            return list.ToString();
        }
    }
}
