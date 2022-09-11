// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double [size];
int counter = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите  {i+1} число массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(" , ",array)+']');

for (int i = 0; i <size;i++)
{
    if(array[i]>0){counter+=1;}
}
Console.WriteLine(counter);