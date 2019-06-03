``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HOVVPS : .NET Core ? (CoreCLR 4.700.19.30102, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                         Method |       Mean |     Error |    StdDev |     Median |        Min |        Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|------------:|------------:|------------:|--------------------:|
|                DeserializeDict |   760.4 ns | 29.023 ns | 33.423 ns |   759.5 ns |   722.5 ns |   836.8 ns |      0.0971 |           - |           - |               416 B |
|               DeserializeIDict |   735.2 ns |  8.502 ns |  7.953 ns |   734.6 ns |   727.0 ns |   756.2 ns |      0.0981 |           - |           - |               416 B |
|       DeserializeIReadOnlyDict |   732.7 ns |  5.217 ns |  4.624 ns |   732.8 ns |   725.6 ns |   743.9 ns |      0.0974 |           - |           - |               416 B |
|       DeserializeImmutableDict | 1,825.4 ns | 24.206 ns | 22.642 ns | 1,825.1 ns | 1,800.5 ns | 1,875.2 ns |      0.2454 |           - |           - |              1048 B |
|      DeserializeIImmutableDict | 1,822.6 ns | 21.718 ns | 18.136 ns | 1,822.8 ns | 1,791.7 ns | 1,853.5 ns |      0.2494 |           - |           - |              1048 B |
| DeserializeImmutableSortedDict | 2,160.8 ns | 41.677 ns | 46.323 ns | 2,169.2 ns | 2,094.4 ns | 2,253.0 ns |      0.3666 |           - |           - |              1544 B |
