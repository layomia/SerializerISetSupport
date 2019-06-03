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
|    SerializeToString | 40.96 us | 3.0479 us | 3.2612 us | 39.36 us | 37.89 us | 48.07 us |      6.2197 |      0.4551 |           - |             26816 B |
| SerializeToUtf8Bytes | 36.32 us | 0.4098 us | 0.3833 us | 36.36 us | 35.77 us | 37.19 us |      3.1465 |      0.1430 |           - |             13656 B |
|    SerializeToStream | 35.09 us | 0.2430 us | 0.2273 us | 35.08 us | 34.82 us | 35.58 us |           - |           - |           - |               464 B |
