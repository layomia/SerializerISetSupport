``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-TIAMPF : .NET Core ? (CoreCLR 4.700.19.27904, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 483.2 us | 4.095 us | 3.830 us | 483.2 us | 477.3 us | 489.1 us |     36.6089 |     11.5607 |           - |           154.06 KB |
| DeserializeFromUtf8Bytes | 461.3 us | 3.478 us | 3.084 us | 461.0 us | 457.6 us | 467.3 us |     16.4835 |      1.8315 |           - |            74.43 KB |
|    DeserializeFromStream | 567.8 us | 3.394 us | 2.834 us | 566.8 us | 563.6 us | 574.1 us |     18.1406 |      4.5351 |           - |             74.5 KB |
