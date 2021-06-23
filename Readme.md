# [BenchmarkDotNet](https://benchmarkdotnet.org/index.html) (exemplo)
   
 - Clonar o projeto

 - Baixar a dependências
   - `dotnet restore`

 - Acessar a pasta do Robô e gerar uma release
   - `cd src/Robot`
   - `dotnet publish -c release`

 - Executar a release
   - `dotnet bin/Release/netcoreapp3.1/robot.dll`

 - As métricas estarão disponíveis no seguinte diretório:
   - `Robot/BenchmarkDotNet.Artifacts/results`

 - Importante
   - Não contempla métodos que recebem parâmetros
     - parâmetros com tipo primitivo existe um workaround para resolver, mas parâmetros de tipos complexos inviabilizam a métrica
   - Não contempla Injeção de dependência

 - Links Úteis
   - https://jeremylindsayni.wordpress.com/2017/06/22/measure-your-codes-performance-during-development-with-benchmarkdotnet-and-net-core/
   - https://jeremylindsayni.wordpress.com/2017/06/25/measure-code-performance-during-development-with-benchmarkdotnet-part-2-methods-with-data-transfer-object-parameters/
   - https://dev.to/newday-technology/measuring-performance-using-benchmarkdotnet-part-1-39g3

## Resultado

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
