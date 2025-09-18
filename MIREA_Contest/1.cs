public class _1
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if (top != '(') return false;
            }
            else if (c == '}')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if (top != '{') return false;
            }
            else if (c == ']')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if (top != '[') return false;
            }
        }

        if (stack.Count == 0) return true;
        return false;
    }
}

/*class Program
{
    static void Main()
    {
        _1 sol = new _1();

        Console.WriteLine(sol.IsValid("()"));       // true
        Console.WriteLine(sol.IsValid("()[]{}"));   // true
        Console.WriteLine(sol.IsValid("(]"));       // false
        Console.WriteLine(sol.IsValid("([])"));     // true
        Console.WriteLine(sol.IsValid("([)]"));     // false
    }
}*/
