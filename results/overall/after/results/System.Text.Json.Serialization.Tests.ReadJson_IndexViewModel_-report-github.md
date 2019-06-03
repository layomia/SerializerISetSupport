``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HOVVPS : .NET Core ? (CoreCLR 4.700.19.30102, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 50.63 us | 1.2366 us | 1.1567 us | 50.29 us | 49.29 us | 53.44 us |      8.4215 |      0.3917 |           - |             34.8 KB |
| DeserializeFromUtf8Bytes | 45.96 us | 0.1671 us | 0.1563 us | 45.95 us | 45.61 us | 46.22 us |      5.3328 |      0.5517 |           - |            21.91 KB |
|    DeserializeFromStream | 47.89 us | 0.3914 us | 0.3661 us | 47.90 us | 47.24 us | 48.36 us |      5.3354 |           - |           - |            21.98 KB |
