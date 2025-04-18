using BenchmarkDotNet.Running;
using services;

namespace robot;

class Program
{
    /// <summary>
    /// Inicia a execução de benchmarks para a classe FooService utilizando o BenchmarkDotNet.
    /// </summary>
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<FooService>();
    }
}
