``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HOVVPS : .NET Core ? (CoreCLR 4.700.19.30102, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                                Method |       Mean |     Error |    StdDev |     Median |        Min |        Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|-------------------------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|------------:|------------:|------------:|--------------------:|
|             SerializeDict_ToUtf8Bytes |   847.9 ns | 23.728 ns | 27.325 ns |   844.0 ns |   818.0 ns |   914.9 ns |      0.0947 |           - |           - |               400 B |
|            SerializeIDict_ToUtf8Bytes |   827.3 ns |  8.392 ns |  7.007 ns |   829.8 ns |   811.5 ns |   834.3 ns |      0.0926 |           - |           - |               400 B |
|    SerializeIReadOnlyDict_ToUtf8Bytes |   840.1 ns |  4.493 ns |  4.202 ns |   839.0 ns |   832.4 ns |   850.3 ns |      0.0935 |           - |           - |               400 B |
|                SerializeDict_ToString |   836.0 ns | 11.850 ns | 10.505 ns |   835.9 ns |   813.2 ns |   855.7 ns |      0.1004 |           - |           - |               432 B |
|               SerializeIDict_ToString |   836.4 ns | 21.009 ns | 23.351 ns |   829.1 ns |   811.9 ns |   885.9 ns |      0.1015 |           - |           - |               432 B |
|       SerializeIReadOnlyDict_ToString |   876.3 ns | 44.370 ns | 51.096 ns |   876.8 ns |   822.3 ns |   969.4 ns |      0.1026 |           - |           - |               432 B |
|        SerializeImmutableDict_ToBytes | 1,697.7 ns | 77.688 ns | 86.350 ns | 1,707.6 ns | 1,579.9 ns | 1,899.8 ns |      0.1795 |           - |           - |               752 B |
|       SerializeIImmutableDict_ToBytes | 1,627.2 ns | 24.549 ns | 21.762 ns | 1,625.1 ns | 1,594.5 ns | 1,676.8 ns |      0.1741 |           - |           - |               752 B |
|  SerializeImmutableSortedDict_ToBytes | 1,458.5 ns | 77.581 ns | 76.195 ns | 1,429.4 ns | 1,396.6 ns | 1,641.9 ns |      0.1525 |           - |           - |               656 B |
|       SerializeImmutableDict_ToString | 1,659.2 ns | 13.649 ns | 12.099 ns | 1,655.5 ns | 1,645.2 ns | 1,685.0 ns |      0.1866 |           - |           - |               784 B |
|      SerializeIImmutableDict_ToString | 1,654.4 ns | 17.178 ns | 14.344 ns | 1,656.4 ns | 1,631.5 ns | 1,687.4 ns |      0.1853 |           - |           - |               784 B |
| SerializeImmutableSortedDict_ToString | 1,370.1 ns |  8.699 ns |  7.712 ns | 1,367.9 ns | 1,358.7 ns | 1,384.3 ns |      0.1634 |           - |           - |               688 B |
