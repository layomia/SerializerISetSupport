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
|    SerializeToString | 1.239 us | 0.0197 us | 0.0184 us | 1.234 us | 1.218 us | 1.270 us |      0.1375 |           - |           - |               584 B |
| SerializeToUtf8Bytes | 1.126 us | 0.0050 us | 0.0042 us | 1.125 us | 1.116 us | 1.131 us |      0.0865 |           - |           - |               376 B |
|    SerializeToStream | 1.221 us | 0.0099 us | 0.0093 us | 1.222 us | 1.209 us | 1.237 us |      0.0338 |           - |           - |               144 B |
