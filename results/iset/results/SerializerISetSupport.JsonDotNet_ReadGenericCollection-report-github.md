``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-ACVUQY : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                Method | ElementCount |        Mean |        Error |       StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------- |------------:|-------------:|-------------:|-------:|------:|------:|----------:|
|       **DeserializeISet** |            **2** | **18,856.7 ns** | **3,210.837 ns** | **9,315.219 ns** |      **-** |     **-** |     **-** |   **2.84 KB** |
| SerializeISet_ToBytes |            2 |    506.5 ns |     9.487 ns |     8.874 ns | 0.3328 |     - |     - |   1.36 KB |
|       **DeserializeISet** |          **100** | **16,909.4 ns** |    **69.621 ns** |    **58.137 ns** | **3.3264** |     **-** |     **-** |   **13.7 KB** |
| SerializeISet_ToBytes |          100 |  8,577.5 ns |   171.278 ns |   442.123 ns | 1.1902 |     - |     - |    4.9 KB |
