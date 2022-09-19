// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(int[,] pArray)
{
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
                for (int j = 0; j < pArray.GetLength(1); j++)
        {
            Console.Write(pArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}


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
int temp = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1])
            {
                temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(array);
