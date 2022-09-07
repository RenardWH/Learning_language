// Дополнительная задача (необязательная)
// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, 
//либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1

Random rand = new Random();
int size = rand.Next(0, 10);
int [] array = new int[size];

for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(1, 10);
}
Console.WriteLine('[' + string.Join(" , ",array)+']');

int Cycle (int a)
{
    int mult  =1;
    for (int i = 0;i<a;i++)
    {
        mult = mult * (a-i);
    }
    return mult;
}

for (int i = 0; i<size;i++)
{
    array[i]=Cycle(array[i]);
}

Console.WriteLine('[' + string.Join(" , ",array)+']');