// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void MaxAndMin (double [] arr)
{
    double min = arr[0];
    double max = arr[0];
    int count = arr.Length;
    for (int i = 1; i<count;i++)
    {
        if (arr[i]<min)
        {
            min=arr[i];
        }
        if (arr[i]>max)
        {
            max=arr[i];
        }
    }
    Console.WriteLine(max-min);
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double [size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите  {i+1} число массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(" , ",array)+']');

MaxAndMin(array);

