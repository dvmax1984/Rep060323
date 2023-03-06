public static class Library
{
    public static int GetNumber(string s)
    {
        Console.Write(s);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int GetResult(int n)
    {
        int p = 1;

        for (int i = 1; i < n; i++)
        {
            p = p * (i + 1);

            
        }
        return p;
    }
}

