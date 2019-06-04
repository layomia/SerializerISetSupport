``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 2.076 us | 0.0236 us | 0.0221 us | 2.072 us | 2.045 us | 2.114 us |      0.1574 |           - |           - |               680 B |
| DeserializeFromUtf8Bytes | 1.895 us | 0.0241 us | 0.0226 us | 1.897 us | 1.855 us | 1.940 us |      0.1058 |           - |           - |               448 B |
|    DeserializeFromStream | 2.260 us | 0.0303 us | 0.0269 us | 2.254 us | 2.214 us | 2.307 us |      0.1155 |           - |           - |               520 B |
