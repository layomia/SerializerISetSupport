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
|    DeserializeFromString | 52.12 us | 0.3429 us | 0.3039 us | 52.19 us | 51.48 us | 52.50 us |      8.5062 |      1.0373 |           - |            34.79 KB |
| DeserializeFromUtf8Bytes | 47.96 us | 0.2781 us | 0.2322 us | 47.97 us | 47.46 us | 48.45 us |      5.1813 |           - |           - |            21.88 KB |
|    DeserializeFromStream | 49.20 us | 0.3119 us | 0.2917 us | 49.09 us | 48.87 us | 49.71 us |      5.2458 |      0.1943 |           - |            21.95 KB |
