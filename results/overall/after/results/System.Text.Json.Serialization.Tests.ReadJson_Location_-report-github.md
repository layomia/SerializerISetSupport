``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HOVVPS : .NET Core ? (CoreCLR 4.700.19.30102, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 1.981 us | 0.0287 us | 0.0269 us | 1.991 us | 1.939 us | 2.019 us |      0.1596 |           - |           - |               680 B |
| DeserializeFromUtf8Bytes | 1.808 us | 0.0111 us | 0.0103 us | 1.809 us | 1.785 us | 1.827 us |      0.1007 |           - |           - |               448 B |
|    DeserializeFromStream | 2.159 us | 0.0289 us | 0.0270 us | 2.147 us | 2.131 us | 2.207 us |      0.1230 |           - |           - |               520 B |
