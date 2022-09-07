// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите 8 чисел массива");
int size = 8;
double [] arr = new double[size];

for (int i = 0; i<size;i++)
{
    arr[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine('[' + string.Join(" , ",arr)+']');
