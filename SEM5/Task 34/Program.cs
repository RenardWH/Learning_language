// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Random rand = new Random();
int size = rand.Next(1, 10);
int [] array = new int[size];
int counter = 0;
for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(100, 1000);
}
Console.WriteLine('[' + string.Join(" , ",array)+']');
for(int i = 0; i < size; i++)
{
    if(array[i] %2 == 0)
    {
        counter +=1;
    }
}
Console.WriteLine(counter);