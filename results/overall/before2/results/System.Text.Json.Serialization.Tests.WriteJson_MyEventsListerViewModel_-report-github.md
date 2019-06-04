``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-DRWCLL : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 728.2 us | 13.59 us | 12.71 us | 724.2 us | 708.5 us | 757.9 us |     46.8750 |     46.8750 |     46.8750 |           327.98 KB |
| SerializeToUtf8Bytes | 700.0 us | 44.59 us | 47.71 us | 676.1 us | 655.6 us | 846.8 us |     59.8958 |     10.4167 |           - |           249.13 KB |
|    SerializeToStream | 659.0 us | 13.05 us | 11.57 us | 663.7 us | 642.3 us | 672.8 us |     39.0625 |           - |           - |           169.84 KB |
