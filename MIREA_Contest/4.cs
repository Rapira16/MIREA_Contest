using System;

public class _4
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        char[] arr1 = s.ToCharArray();
        char[] arr2 = t.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        string sortedS = new string(arr1);
        string sortedT = new string(arr2);

        return sortedS == sortedT;
    }
}

/*class Program
{
    static void Main()
    {
        _4 sol = new _4();

        string s1 = "anagram", t1 = "nagaram";
        Console.WriteLine(sol.IsAnagram(s1, t1));
    }
}*/