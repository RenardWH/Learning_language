/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*Решение 1

Console.WriteLine("Введите целое число");

double N = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

if (N == 0)
{
    
    Console.WriteLine(0);
}
else
{
for (int i = 1; i <= Math.Abs(N); i++)
{
    
    Console.WriteLine(Math.Pow(N, i));
}

}*/

//Решение 2

Console.WriteLine("Введите целое число");

double N = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double Num = 1;
if (N == 0)
{
    
    Console.WriteLine(0);
}
else
{
for (int i = 1; i <= Math.Abs(N); i++)
{
    Num = Num * N;
    Console.WriteLine(Num);
    
}

}