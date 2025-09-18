using System;
using System.Collections.Generic;

public class RecentCounter
{
    private List<int> requests = new List<int>();

    public int Ping(int t)
    {
        requests.Add(t);
        int low = t - 3000;
        int c = 0;
        for (int i = 0; i < requests.Count; i++)
        {
            if (requests[i] >= low)
                c++;
        }
        return c;
    }
}

/*class Program
{
    static void Main()
    {
        RecentCounter recentCounter = new RecentCounter();

        Console.WriteLine(recentCounter.Ping(1));    // Ожидаем: 1
        Console.WriteLine(recentCounter.Ping(100));  // Ожидаем: 2
        Console.WriteLine(recentCounter.Ping(3001)); // Ожидаем: 3
        Console.WriteLine(recentCounter.Ping(3002)); // Ожидаем: 3
    }
}*/
