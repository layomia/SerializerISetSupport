``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HOVVPS : .NET Core ? (CoreCLR 4.700.19.30102, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 685.6 us | 13.704 us | 13.459 us | 681.7 us | 672.9 us | 718.2 us |     97.8261 |     48.9130 |     48.9130 |           392.09 KB |
| SerializeToUtf8Bytes | 635.5 us |  9.385 us |  8.779 us | 631.9 us | 627.6 us | 660.2 us |     73.8636 |     14.2045 |           - |           312.48 KB |
|    SerializeToStream | 641.3 us |  6.647 us |  5.892 us | 639.6 us | 634.0 us | 653.8 us |     53.5714 |           - |           - |           232.84 KB |
