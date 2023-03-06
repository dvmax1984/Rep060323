Console.WriteLine("Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");


Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int p = 1;

for (int i = 1; i < n; i++)
{
    p = p * (i + 1);
       
    Console.WriteLine(p);
}
