``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-DRWCLL : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 536.4 ns |  3.136 ns | 2.780 ns | 536.6 ns | 532.7 ns | 540.7 ns |      0.0800 |           - |           - |               336 B |
| SerializeToUtf8Bytes | 491.2 ns |  6.654 ns | 5.898 ns | 491.7 ns | 476.6 ns | 502.0 ns |      0.0611 |           - |           - |               256 B |
|    SerializeToStream | 601.5 ns | 11.767 ns | 9.187 ns | 605.9 ns | 582.1 ns | 611.0 ns |      0.0336 |           - |           - |               144 B |
