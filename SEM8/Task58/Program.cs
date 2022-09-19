// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    Random rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
         array[i,j] = rand.Next(1,100);
         Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }   
}

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

Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int [,] arrayA = new int[m,m];
int [,] arrayB = new int[m,m];
int [,] arrayResult = new int[m,m];

FillArray(arrayA);
FillArray(arrayB);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m; k++)
        {
            arrayResult[i, j] = arrayResult[i, j] + (arrayA[i, k] * arrayB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(arrayB);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
PrintArray(arrayResult);