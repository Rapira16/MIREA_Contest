using System;

public class _3
{
    public int MaxProfit(int[] prices)
    {
        int min = 2147483647;
        int max = 0;

        foreach (int p in prices)
        {
            if (p < min)
            {
                min = p;
            }
            else if (p - min > max)
            {
                max = p - min;
            }
        }

        return max;
    }
}

/*class Program
{
    static void Main()
    {
        _3 sol = new _3();

        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(sol.MaxProfit(prices1));
    }
}*/
