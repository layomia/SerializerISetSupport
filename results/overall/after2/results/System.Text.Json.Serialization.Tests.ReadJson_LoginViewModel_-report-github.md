``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |       Mean |    Error |   StdDev |     Median |      Min |        Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |-----------:|---------:|---------:|-----------:|---------:|-----------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString |   742.2 ns | 16.05 ns | 16.48 ns |   740.5 ns | 721.3 ns |   783.7 ns |      0.0656 |           - |           - |               280 B |
| DeserializeFromUtf8Bytes |   682.3 ns | 17.38 ns | 19.32 ns |   684.3 ns | 656.4 ns |   715.7 ns |      0.0375 |           - |           - |               168 B |
|    DeserializeFromStream | 1,014.1 ns | 19.53 ns | 19.18 ns | 1,008.2 ns | 992.5 ns | 1,067.0 ns |      0.0566 |           - |           - |               240 B |
