// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


Random rand = new Random();
int size = 123;
int [] array = new int[size];
int counter = 0;
for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(0,1000); // слегка ограничу, чтобы вероятность появления числа между 10 и 99 была выше
}
Console.WriteLine('[' + string.Join(" , ",array)+']');
for(int i = 0; i < size; i++)
{
    if(array[i] >=10&&array[i] <=100)
    {
        counter +=1;
    }
}
Console.WriteLine(counter);