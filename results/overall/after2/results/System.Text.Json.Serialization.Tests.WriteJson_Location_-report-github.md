``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.18362
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012162
  [Host]     : .NET Core 3.0.0-preview6-27730-01 (CoreCLR 4.700.19.28001, CoreFX 4.700.19.27908), 64bit RyuJIT
  Job-PXGTGS : .NET Core ? (CoreCLR 4.700.19.30201, CoreFX 4.700.19.30401), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 1.252 us | 0.0134 us | 0.0105 us | 1.250 us | 1.240 us | 1.271 us |      0.1353 |           - |           - |               584 B |
| SerializeToUtf8Bytes | 1.199 us | 0.0138 us | 0.0129 us | 1.200 us | 1.179 us | 1.226 us |      0.0862 |           - |           - |               376 B |
|    SerializeToStream | 1.310 us | 0.0155 us | 0.0138 us | 1.314 us | 1.288 us | 1.328 us |      0.0313 |           - |           - |               144 B |
