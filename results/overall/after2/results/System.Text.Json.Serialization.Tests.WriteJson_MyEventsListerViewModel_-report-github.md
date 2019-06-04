``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 709.3 us | 6.389 us | 5.664 us | 708.9 us | 700.3 us | 721.0 us |     97.8261 |     48.9130 |     48.9130 |           392.38 KB |
| SerializeToUtf8Bytes | 675.2 us | 3.836 us | 3.588 us | 675.4 us | 668.5 us | 680.4 us |     76.0870 |     13.5870 |           - |           312.71 KB |
|    SerializeToStream | 669.4 us | 4.418 us | 4.133 us | 670.3 us | 660.6 us | 673.9 us |     56.5476 |           - |           - |           232.84 KB |
