using System;
using BenchmarkDotNet.Running;
using services;

namespace robot
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<FooService>();
        }
    }
}
