using System.Collections.Generic;
using System.Threading;
using BenchmarkDotNet.Attributes;

namespace services;

[MemoryDiagnoser]
public class FooService
{
    /// <summary>
    /// Pausa a execução por 1 segundo.
    /// </summary>
    [Benchmark]
    public void TestFoo01() => Thread.Sleep(1000);

    /// <summary>
    /// Pausa a execução por 2 segundos.
    /// </summary>
    [Benchmark]
    public void TestFoo02() => Thread.Sleep(2000);

    /// <summary>
    /// Cria uma lista de 50.000 strings, convertendo cada número de 0 a 49.999 em texto e adicionando à lista.
    /// </summary>
    [Benchmark]
    public void TestFoo03()
    {
        var list = new List<string>();
        for (int i = 0; i < 50000; i++)
        {
            list.Add(i.ToString());
        }
    }

    private void Teste() {}
}
