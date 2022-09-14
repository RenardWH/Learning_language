// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите размер массива - строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива - столбцы");
int n = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int [,] array = new int[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
    array[i,j] = rand.Next(1,10);
    Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}
double Sum = 0;
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for(int j = 0; j < n; j++)
{
    for(int i = 0; i < m; i++)
    {
    Sum = Sum+Convert.ToDouble(array[i,j]);
    }
    Console.Write(Sum/m + ";");
    Sum = 0;
}