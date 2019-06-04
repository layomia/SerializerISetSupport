``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-DRWCLL : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 41.64 us | 0.5967 us | 0.5289 us | 41.83 us | 40.49 us | 42.28 us |      6.3976 |      0.4921 |           - |             26856 B |
| SerializeToUtf8Bytes | 39.02 us | 0.6882 us | 0.6438 us | 38.63 us | 38.46 us | 40.11 us |      3.1888 |           - |           - |             13656 B |
|    SerializeToStream | 39.22 us | 0.7570 us | 0.7774 us | 39.57 us | 37.71 us | 40.10 us |           - |           - |           - |               464 B |
