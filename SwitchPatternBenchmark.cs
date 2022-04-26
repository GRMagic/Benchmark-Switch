using BenchmarkDotNet.Attributes;

[MemoryDiagnoser(false)]
public class SwitchPatternBenchmark
{
    [Params(
        new int[]{1,2,3,4,5,6,7}
    )]
    public int[] Args { get; set; }

    [Benchmark]
    public int SwitchPattern_Array()
    {
        return SwitchPattern.SwitchPattern_Array(Args);
    }

    [Benchmark]
    public int SwitchPattern_Span()
    {
        return SwitchPattern.SwitchPattern_Span(Args);
    }

    [Benchmark]
    public int SwitchPattern_ReadOnlySpan()
    {
        return SwitchPattern.SwitchPattern_ReadOnlySpan(Args);
    }
}