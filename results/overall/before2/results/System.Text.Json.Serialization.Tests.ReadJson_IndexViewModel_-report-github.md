``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-DRWCLL : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 57.99 us | 0.8682 us | 0.8121 us | 58.19 us | 56.29 us | 59.38 us |      8.4225 |      0.9105 |           - |            34.82 KB |
| DeserializeFromUtf8Bytes | 52.38 us | 0.7255 us | 0.6058 us | 52.09 us | 51.89 us | 53.65 us |      5.1813 |      0.6477 |           - |            21.91 KB |
|    DeserializeFromStream | 54.82 us | 0.9815 us | 0.9181 us | 54.82 us | 53.46 us | 56.71 us |      5.3464 |           - |           - |            21.98 KB |
