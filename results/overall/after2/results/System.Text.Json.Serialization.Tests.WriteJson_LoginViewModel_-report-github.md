``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 507.5 ns | 5.024 ns | 4.453 ns | 508.4 ns | 499.9 ns | 513.9 ns |      0.0798 |           - |           - |               336 B |
| SerializeToUtf8Bytes | 470.0 ns | 8.114 ns | 7.590 ns | 469.1 ns | 460.3 ns | 484.8 ns |      0.0596 |           - |           - |               256 B |
|    SerializeToStream | 565.5 ns | 2.886 ns | 2.253 ns | 565.3 ns | 561.6 ns | 569.7 ns |      0.0342 |           - |           - |               144 B |
