// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
    array[i,j] = rand.Next(1,100);
    Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите индекс строки для нужного элемента");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца для нужного элемента");
int column = Convert.ToInt32(Console.ReadLine());

if (line>m-1||column>n-1)
{
    Console.WriteLine("Такой позиции нет");
}
else
{
     Console.WriteLine(array[line,column]);
}