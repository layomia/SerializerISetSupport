``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 519.2 us | 4.724 us | 4.419 us | 517.4 us | 514.1 us | 530.2 us |     35.0515 |     10.3093 |           - |           154.28 KB |
| DeserializeFromUtf8Bytes | 498.9 us | 3.306 us | 2.761 us | 497.7 us | 495.4 us | 503.8 us |     17.7866 |      3.9526 |           - |            74.46 KB |
|    DeserializeFromStream | 620.2 us | 3.790 us | 3.545 us | 620.3 us | 615.3 us | 627.5 us |     17.3697 |      4.9628 |           - |            74.53 KB |
