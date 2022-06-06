using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace BestPratices
{
    [MemoryDiagnoser]
    internal static class ObsoleteDemo
    {
        [Obsolete("This method will be deprecated soon. You could use GetValuesGreaterThan100New alternatively.")]
        [Benchmark]
        public static IEnumerable<int> GetValuesGreaterThan100Old(List<int> masterCollection)
        {
            List<int> tempResult = new List<int>();

            foreach (var value in masterCollection)
            {
                if (value > 100)
                    tempResult.Add(value);
            }

            return tempResult;
        }

        [Benchmark]
        public static IEnumerable<int> GetValuesGreaterThan100New(List<int> masterCollection)
        {
            foreach (var value in masterCollection)
                if (value > 100)
                    yield return value;
        }
    }
}
