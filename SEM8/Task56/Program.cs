// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();
int [,] array = new int[m,m];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < m; j++)
    {
    array[i,j] = rand.Next(1,100);
    Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}
int temp = 0;
for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        temp = temp + array[0,j];
    }
int min = temp;
int minIndex = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = temp + array[i,j];
    }
    if (temp<min)
    {
        min=temp;
        minIndex=i;
    }
}

Console.WriteLine( minIndex+1+" строка");
