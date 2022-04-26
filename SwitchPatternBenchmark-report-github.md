``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100-preview.3.22179.4
  [Host]     : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT


```
|                     Method |     Args |      Mean |     Error |    StdDev | Allocated |
|--------------------------- |--------- |----------:|----------:|----------:|----------:|
|        SwitchPattern_Array | Int32[7] | 17.367 ns | 0.2171 ns | 0.2031 ns |      48 B |
|         SwitchPattern_Span | Int32[7] |  6.397 ns | 0.0060 ns | 0.0047 ns |         - |
| SwitchPattern_ReadOnlySpan | Int32[7] |  7.016 ns | 0.0176 ns | 0.0156 ns |         - |
