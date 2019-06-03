``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HOVVPS : .NET Core ? (CoreCLR 4.700.19.30102, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 489.5 us | 5.021 us | 4.193 us | 488.1 us | 486.0 us | 501.5 us |     35.2250 |     11.7417 |           - |           154.28 KB |
| DeserializeFromUtf8Bytes | 479.8 us | 8.351 us | 7.812 us | 479.0 us | 468.7 us | 497.8 us |     17.1756 |      3.8168 |           - |            74.46 KB |
|    DeserializeFromStream | 584.0 us | 3.588 us | 3.180 us | 584.1 us | 577.6 us | 590.7 us |     16.3170 |      4.6620 |           - |            74.53 KB |
