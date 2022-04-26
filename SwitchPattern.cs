public class SwitchPattern
{
    public static int SwitchPattern_Span(Span<int> inc)
    {
        return inc switch
        {
            [] => 0,
            [_, int second] => second,
            [_, .. Span<int> middle, _] => Sum(middle),
            _ => -1
        };
    }

    public static int SwitchPattern_ReadOnlySpan(ReadOnlySpan<int> inc)
    {
        return inc switch
        {
            [] => 0,
            [_, int second] => second,
            [_, .. ReadOnlySpan<int> middle, _] => Sum(middle),
            _ => -1
        };
    }

    public static int SwitchPattern_Array(int[] inc)
    {
        return inc switch
        {
            [] => 0,
            [_, int second] => second,
            [_, .. int[] middle, _] => Sum(middle),
            _ => -1
        };
    }

    private static int Sum(ReadOnlySpan<int> inc)
    {
        int sum = 0;
        for (int i = 0; i < inc.Length; i++)
        {
            sum += inc[i];
        }
        return sum;
    }
}