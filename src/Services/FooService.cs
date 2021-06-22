using System;
using System.Collections.Generic;
using System.Threading;
using BenchmarkDotNet.Attributes;

namespace services
{
    [MemoryDiagnoser]
    public class FooService
    {
        [Benchmark]
        public void TestFoo01() => Thread.Sleep(1000);

        [Benchmark]
        public void TestFoo02() => Thread.Sleep(2000);

        [Benchmark]
        public void TestFoo03()
        {
            var list = new List<string>();
            for (int i = 0; i < 50000; i++)
            {
                list.Add(i.ToString());
            }
        }
    }
}
