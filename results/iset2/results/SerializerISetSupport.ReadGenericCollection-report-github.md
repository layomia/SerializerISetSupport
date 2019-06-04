``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-TUSYED : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                Method | ElementCount |        Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------- |------------:|-----------:|-----------:|-------:|------:|------:|----------:|
|       **DeserializeISet** |            **2** |  **2,114.5 ns** |  **41.533 ns** |  **44.440 ns** | **0.2747** |     **-** |     **-** |    **1160 B** |
| SerializeISet_ToBytes |            2 |    507.2 ns |   5.404 ns |   4.791 ns | 0.0591 |     - |     - |     248 B |
|       **DeserializeISet** |           **50** | **11,712.8 ns** | **252.800 ns** | **346.035 ns** | **1.8616** |     **-** |     **-** |    **7817 B** |
| SerializeISet_ToBytes |           50 |  5,993.0 ns | 106.807 ns |  99.907 ns | 0.2823 |     - |     - |    1192 B |
|       **DeserializeISet** |          **100** | **21,081.3 ns** | **124.253 ns** | **103.757 ns** | **3.6621** |     **-** |     **-** |   **15353 B** |
| SerializeISet_ToBytes |          100 | 11,535.3 ns | 173.335 ns | 135.328 ns | 0.5188 |     - |     - |    2192 B |
