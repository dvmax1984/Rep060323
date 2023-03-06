public static class Library
{
    public static int GetNumber(string s)
    {
        Console.Write(s);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void GetResult(int n)
    {
        int p = 1;

        for (int i = 1; i < n; i++)
        {
            p = p * (i + 1);

            Console.WriteLine(p);
        }
    }
}

