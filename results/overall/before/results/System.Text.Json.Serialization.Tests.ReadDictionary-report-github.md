``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-TIAMPF : .NET Core ? (CoreCLR 4.700.19.27904, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                         Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|                DeserializeDict | 730.4 ns | 24.149 ns | 26.842 ns | 725.3 ns | 699.6 ns | 789.9 ns |      0.0974 |           - |           - |               416 B |
|               DeserializeIDict | 729.6 ns | 16.810 ns | 17.987 ns | 723.9 ns | 708.7 ns | 778.2 ns |      0.0975 |           - |           - |               416 B |
|       DeserializeIReadOnlyDict | 729.0 ns |  8.683 ns |  7.250 ns | 728.9 ns | 720.1 ns | 748.2 ns |      0.0968 |           - |           - |               416 B |
|       DeserializeImmutableDict |       NA |        NA |        NA |       NA |       NA |       NA |           - |           - |           - |                   - |
|      DeserializeIImmutableDict |       NA |        NA |        NA |       NA |       NA |       NA |           - |           - |           - |                   - |
| DeserializeImmutableSortedDict |       NA |        NA |        NA |       NA |       NA |       NA |           - |           - |           - |                   - |

Benchmarks with issues:
  ReadDictionary.DeserializeImmutableDict: Job-TIAMPF(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
  ReadDictionary.DeserializeIImmutableDict: Job-TIAMPF(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
  ReadDictionary.DeserializeImmutableSortedDict: Job-TIAMPF(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
