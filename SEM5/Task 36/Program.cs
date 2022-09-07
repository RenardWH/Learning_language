// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Random rand = new Random();
int size = rand.Next(0,15);
int [] array = new int[size];
int sum = 0;
for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(-100,100); // слегка ограничу для удобства
}
Console.WriteLine('[' + string.Join(" , ",array)+']');
for(int i = 1; i < size; i=i+2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);