// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N, для вывода произведение чисел от 1 до N");
int N = Convert.ToInt32(Console.ReadLine());
if (N<1)
{
    Console.WriteLine("Введите число N, для вывода произведение чисел от 1 до N");
    N = Convert.ToInt32(Console.ReadLine());
}

int  MultiplyN (int F)
{
    if(F == 1)
    {
        return F;
    }
    else
    {
        return F*MultiplyN(F-1);
    }
}
int result = MultiplyN(N);
Console.WriteLine($"{N} -> {result}");