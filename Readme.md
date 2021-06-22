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
