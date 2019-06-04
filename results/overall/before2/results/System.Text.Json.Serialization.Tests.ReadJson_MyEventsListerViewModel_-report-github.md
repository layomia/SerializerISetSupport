``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-DRWCLL : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 528.3 us | 10.165 us | 9.983 us | 531.9 us | 515.6 us | 540.2 us |     35.6394 |     10.4822 |           - |           153.72 KB |
| DeserializeFromUtf8Bytes | 503.7 us |  6.768 us | 6.000 us | 501.4 us | 495.9 us | 515.6 us |     16.3599 |      4.0900 |           - |            74.46 KB |
|    DeserializeFromStream | 635.6 us |  6.178 us | 5.779 us | 636.9 us | 616.4 us | 640.5 us |     17.8571 |      5.1020 |           - |            74.53 KB |
