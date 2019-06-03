``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-TIAMPF : .NET Core ? (CoreCLR 4.700.19.27904, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |    Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|---------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 693.4 us | 10.51 us |  9.313 us | 694.5 us | 678.7 us | 710.1 us |     98.2143 |     49.1071 |     49.1071 |           392.52 KB |
| SerializeToUtf8Bytes | 679.4 us | 20.52 us | 21.960 us | 673.1 us | 658.3 us | 734.5 us |     75.8929 |     13.3929 |           - |            312.7 KB |
|    SerializeToStream | 657.0 us | 37.78 us | 38.795 us | 640.2 us | 621.5 us | 744.6 us |     53.5714 |           - |           - |           232.81 KB |
