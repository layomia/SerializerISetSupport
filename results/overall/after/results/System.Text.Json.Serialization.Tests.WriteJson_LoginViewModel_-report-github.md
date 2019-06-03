``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HOVVPS : .NET Core ? (CoreCLR 4.700.19.30102, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 481.9 ns | 2.471 ns | 2.190 ns | 481.8 ns | 477.6 ns | 484.9 ns |      0.0798 |           - |           - |               336 B |
| SerializeToUtf8Bytes | 456.0 ns | 2.654 ns | 2.352 ns | 455.1 ns | 453.1 ns | 459.8 ns |      0.0586 |           - |           - |               256 B |
|    SerializeToStream | 581.3 ns | 3.828 ns | 3.197 ns | 580.6 ns | 577.3 ns | 589.8 ns |      0.0326 |           - |           - |               144 B |
