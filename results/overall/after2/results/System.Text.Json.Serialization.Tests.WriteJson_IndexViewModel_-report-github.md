``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 39.79 us | 0.5071 us | 0.3959 us | 39.83 us | 39.07 us | 40.45 us |      6.2814 |      0.4711 |           - |             26856 B |
| SerializeToUtf8Bytes | 38.68 us | 0.3723 us | 0.3482 us | 38.65 us | 38.08 us | 39.24 us |      3.2328 |           - |           - |             13680 B |
|    SerializeToStream | 39.22 us | 0.4056 us | 0.3794 us | 39.04 us | 38.81 us | 40.01 us |           - |           - |           - |               464 B |
