``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-TUSYED : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                Method | ElementCount |        Mean |       Error |       StdDev |      Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------- |------------:|------------:|-------------:|------------:|-------:|------:|------:|----------:|
|       **DeserializeISet** |            **2** | **21,030.9 ns** | **3,649.67 ns** | **10,412.72 ns** | **17,650.0 ns** |      **-** |     **-** |     **-** |   **2.84 KB** |
| SerializeISet_ToBytes |            2 |    542.6 ns |    10.85 ns |     23.35 ns |    536.1 ns | 0.3328 |     - |     - |   1.36 KB |
|       **DeserializeISet** |           **50** |  **9,447.0 ns** |   **188.40 ns** |    **224.27 ns** |  **9,434.3 ns** | **1.9073** |     **-** |     **-** |   **7.85 KB** |
| SerializeISet_ToBytes |           50 |  4,475.9 ns |    86.77 ns |     72.46 ns |  4,493.8 ns | 0.6943 |     - |     - |   2.85 KB |
|       **DeserializeISet** |          **100** | **18,215.9 ns** |    **70.56 ns** |     **62.55 ns** | **18,209.3 ns** | **3.3264** |     **-** |     **-** |   **13.7 KB** |
| SerializeISet_ToBytes |          100 |  8,535.8 ns |    70.04 ns |     65.51 ns |  8,553.2 ns | 1.1902 |     - |     - |    4.9 KB |
