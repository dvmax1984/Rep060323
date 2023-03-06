Console.WriteLine("Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");

static int GetNumber(string s )
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

static void GetResult(int n)
{
    int p = 1;

    for (int i = 1; i < n; i++)
    {
        p = p * (i + 1);

        Console.WriteLine(p);
    }
}

int n = GetNumber("Введите число N: ");
GetResult(n);