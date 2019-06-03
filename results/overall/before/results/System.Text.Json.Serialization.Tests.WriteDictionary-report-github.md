``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-TIAMPF : .NET Core ? (CoreCLR 4.700.19.27904, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                                Method |       Mean |     Error |    StdDev |     Median |        Min |        Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|-------------------------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|------------:|------------:|------------:|--------------------:|
|             SerializeDict_ToUtf8Bytes |   816.3 ns | 21.152 ns | 24.359 ns |   803.7 ns |   782.9 ns |   860.4 ns |      0.0931 |           - |           - |               400 B |
|            SerializeIDict_ToUtf8Bytes |   823.0 ns | 24.653 ns | 28.390 ns |   812.7 ns |   789.9 ns |   878.3 ns |      0.0926 |           - |           - |               400 B |
|    SerializeIReadOnlyDict_ToUtf8Bytes |   798.4 ns | 12.712 ns | 11.891 ns |   795.3 ns |   781.3 ns |   816.8 ns |      0.0940 |           - |           - |               400 B |
|                SerializeDict_ToString |   811.9 ns |  8.531 ns |  7.980 ns |   813.5 ns |   794.3 ns |   821.2 ns |      0.1026 |           - |           - |               432 B |
|               SerializeIDict_ToString |   779.5 ns |  5.110 ns |  3.990 ns |   780.6 ns |   774.1 ns |   785.5 ns |      0.1012 |           - |           - |               432 B |
|       SerializeIReadOnlyDict_ToString |   812.2 ns |  9.335 ns |  8.275 ns |   811.1 ns |   801.0 ns |   826.4 ns |      0.1002 |           - |           - |               432 B |
|        SerializeImmutableDict_ToBytes | 1,325.5 ns | 16.035 ns | 13.390 ns | 1,323.4 ns | 1,311.9 ns | 1,362.6 ns |      0.1430 |           - |           - |               600 B |
|       SerializeIImmutableDict_ToBytes |         NA |        NA |        NA |         NA |         NA |         NA |           - |           - |           - |                   - |
|  SerializeImmutableSortedDict_ToBytes | 1,145.7 ns | 26.579 ns | 28.439 ns | 1,144.6 ns | 1,106.8 ns | 1,209.0 ns |      0.1190 |           - |           - |               504 B |
|       SerializeImmutableDict_ToString | 1,375.0 ns | 24.834 ns | 22.015 ns | 1,375.9 ns | 1,345.1 ns | 1,416.2 ns |      0.1491 |           - |           - |               632 B |
|      SerializeIImmutableDict_ToString |         NA |        NA |        NA |         NA |         NA |         NA |           - |           - |           - |                   - |
| SerializeImmutableSortedDict_ToString | 1,103.0 ns |  8.644 ns |  8.085 ns | 1,102.1 ns | 1,088.7 ns | 1,119.6 ns |      0.1280 |           - |           - |               536 B |

Benchmarks with issues:
  WriteDictionary.SerializeIImmutableDict_ToBytes: Job-TIAMPF(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
  WriteDictionary.SerializeIImmutableDict_ToString: Job-TIAMPF(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
