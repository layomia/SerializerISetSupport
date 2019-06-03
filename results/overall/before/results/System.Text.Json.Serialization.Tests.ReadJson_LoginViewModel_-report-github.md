``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-TIAMPF : .NET Core ? (CoreCLR 4.700.19.27904, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 693.3 ns | 14.347 ns | 15.946 ns | 698.1 ns | 660.7 ns | 717.0 ns |      0.0658 |           - |           - |               280 B |
| DeserializeFromUtf8Bytes | 604.1 ns |  6.492 ns |  6.072 ns | 602.1 ns | 596.4 ns | 614.7 ns |      0.0383 |           - |           - |               168 B |
|    DeserializeFromStream | 928.9 ns | 14.253 ns | 12.635 ns | 930.1 ns | 909.2 ns | 950.8 ns |      0.0545 |           - |           - |               240 B |
