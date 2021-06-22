``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19041.1052 (2004/May2020Update/20H1)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.203
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  DefaultJob : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT


```
|    Method |         Mean |     Error |    StdDev |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
|---------- |-------------:|----------:|----------:|---------:|---------:|---------:|------------:|
| TestFoo01 | 1,008.643 ms | 4.8535 ms | 4.5400 ms |        - |        - |        - |       856 B |
| TestFoo02 | 2,009.543 ms | 4.2325 ms | 3.9591 ms |        - |        - |        - |           - |
| TestFoo03 |     4.508 ms | 0.0885 ms | 0.1119 ms | 421.8750 | 281.2500 | 281.2500 | 2,648,616 B |
