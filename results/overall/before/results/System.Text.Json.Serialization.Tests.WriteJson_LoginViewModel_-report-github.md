``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-TIAMPF : .NET Core ? (CoreCLR 4.700.19.27904, CoreFX 4.700.19.30301), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 473.1 ns | 4.456 ns | 4.168 ns | 473.2 ns | 466.3 ns | 479.5 ns |      0.0798 |           - |           - |               336 B |
| SerializeToUtf8Bytes | 444.5 ns | 3.291 ns | 3.079 ns | 444.3 ns | 437.7 ns | 451.3 ns |      0.0600 |           - |           - |               256 B |
|    SerializeToStream | 534.6 ns | 4.139 ns | 3.872 ns | 532.8 ns | 531.3 ns | 544.1 ns |      0.0327 |           - |           - |               144 B |
