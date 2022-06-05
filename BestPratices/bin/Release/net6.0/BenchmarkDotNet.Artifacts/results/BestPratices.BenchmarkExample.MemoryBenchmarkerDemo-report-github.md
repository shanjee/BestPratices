``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1706 (21H1/May2021Update)
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|                          Method |       Mean |    Error |    StdDev |     Median |  Gen 0 | Allocated |
|-------------------------------- |-----------:|---------:|----------:|-----------:|-------:|----------:|
| ConcatStringsUsingStringBuilder | 1,160.4 ns | 92.14 ns | 271.67 ns | 1,332.0 ns | 0.3920 |   1,640 B |
|   ConcatStringsUsingGenericList |   728.6 ns | 14.35 ns |  14.74 ns |   727.4 ns | 0.1469 |     616 B |
