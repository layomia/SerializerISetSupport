``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-DRWCLL : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |       Mean |     Error |    StdDev |     Median |        Min |        Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString |   776.2 ns | 15.176 ns | 14.904 ns |   778.4 ns |   751.7 ns |   806.3 ns |      0.0644 |           - |           - |               280 B |
| DeserializeFromUtf8Bytes |   691.9 ns |  4.340 ns |  4.060 ns |   691.2 ns |   686.1 ns |   701.4 ns |      0.0393 |           - |           - |               168 B |
|    DeserializeFromStream | 1,084.3 ns | 21.595 ns | 22.177 ns | 1,080.3 ns | 1,052.7 ns | 1,130.2 ns |      0.0566 |           - |           - |               240 B |
