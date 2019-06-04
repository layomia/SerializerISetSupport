``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-ACVUQY : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                Method | ElementCount |        Mean |     Error |      StdDev |      Median |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------- |------------- |------------:|----------:|------------:|------------:|-------:|-------:|------:|----------:|
|       **DeserializeISet** |            **2** |  **2,070.0 ns** |  **40.97 ns** |   **103.54 ns** |  **2,030.6 ns** | **0.2766** |      **-** |     **-** |    **1160 B** |
| SerializeISet_ToBytes |            2 |    524.7 ns |  10.32 ns |    17.52 ns |    522.7 ns | 0.0591 |      - |     - |     248 B |
|       **DeserializeISet** |          **100** | **22,749.1 ns** | **595.47 ns** | **1,718.07 ns** | **22,233.8 ns** | **3.6621** | **0.0305** |     **-** |   **15353 B** |
| SerializeISet_ToBytes |          100 | 12,471.0 ns | 274.36 ns |   787.19 ns | 12,340.2 ns | 0.5188 |      - |     - |    2192 B |
