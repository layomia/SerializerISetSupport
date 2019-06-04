``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 55.14 us | 0.5265 us | 0.4667 us | 55.06 us | 54.35 us | 55.80 us |      8.4912 |      1.0886 |           - |            34.82 KB |
| DeserializeFromUtf8Bytes | 51.87 us | 0.6300 us | 0.5893 us | 51.89 us | 51.19 us | 52.85 us |      5.1610 |      0.6193 |           - |            21.91 KB |
|    DeserializeFromStream | 53.86 us | 0.5382 us | 0.5034 us | 53.72 us | 53.11 us | 54.76 us |      5.1680 |           - |           - |            21.98 KB |
