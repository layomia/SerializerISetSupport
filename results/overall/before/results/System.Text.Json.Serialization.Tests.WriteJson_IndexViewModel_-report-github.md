``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-TIAMPF : .NET Core ? (CoreCLR 4.700.19.27904, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 37.17 us | 0.2482 us | 0.2200 us | 37.17 us | 36.75 us | 37.59 us |      6.3836 |      0.4454 |           - |             26824 B |
| SerializeToUtf8Bytes | 37.03 us | 0.7304 us | 0.6475 us | 36.83 us | 36.10 us | 38.03 us |      3.1176 |           - |           - |             13648 B |
|    SerializeToStream | 36.63 us | 0.7635 us | 0.6768 us | 36.46 us | 36.02 us | 38.77 us |           - |           - |           - |               432 B |
