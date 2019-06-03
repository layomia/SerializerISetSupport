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
|    SerializeToString | 1.187 us | 0.0091 us | 0.0081 us | 1.187 us | 1.172 us | 1.200 us |      0.1376 |           - |           - |               584 B |
| SerializeToUtf8Bytes | 1.137 us | 0.0116 us | 0.0102 us | 1.133 us | 1.125 us | 1.158 us |      0.0863 |           - |           - |               376 B |
|    SerializeToStream | 1.334 us | 0.0962 us | 0.1069 us | 1.276 us | 1.251 us | 1.618 us |      0.0307 |           - |           - |               144 B |
