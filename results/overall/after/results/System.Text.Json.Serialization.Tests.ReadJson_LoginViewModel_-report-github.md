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
|    DeserializeFromString | 723.0 ns | 13.133 ns | 12.285 ns | 725.5 ns | 700.8 ns | 744.9 ns |      0.0657 |           - |           - |               280 B |
| DeserializeFromUtf8Bytes | 645.9 ns |  8.738 ns |  8.173 ns | 643.6 ns | 636.5 ns | 659.8 ns |      0.0396 |           - |           - |               168 B |
|    DeserializeFromStream | 971.2 ns |  8.991 ns |  8.410 ns | 968.6 ns | 960.0 ns | 985.7 ns |      0.0540 |           - |           - |               240 B |
