``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-DRWCLL : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 2.131 us | 0.0352 us | 0.0312 us | 2.145 us | 2.078 us | 2.178 us |      0.1597 |           - |           - |               680 B |
| DeserializeFromUtf8Bytes | 2.000 us | 0.0113 us | 0.0105 us | 2.001 us | 1.981 us | 2.021 us |      0.1045 |           - |           - |               448 B |
|    DeserializeFromStream | 2.312 us | 0.0237 us | 0.0221 us | 2.315 us | 2.251 us | 2.350 us |      0.1195 |           - |           - |               520 B |
