// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите размер массива - строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива - столбцы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива - глубина");
int k = Convert.ToInt32(Console.ReadLine());
int MaxNumbers = 90*1;
int size = m*n*k;
Random rand = new Random();
if (size > MaxNumbers)
{
    Console.WriteLine("Размер массива слишком большой");
    Console.WriteLine("произведение размеров не должно превышать 90");
    return;
}

int[] numbers = new int[size];
int temp =0;
numbers[0] = rand.Next(10,100);
for (int i =1; i<size;i++)
{
    do
    {
        temp=0;
        numbers[i] = rand.Next(10,100);
        for (int j=0;j<i;j++)
        {
            if (numbers[i]!=numbers[j])
            {
                temp=1;
            }
        }
    }
    while(temp==0);
}
//Console.WriteLine('[' + string.Join(" , ",numbers)+']');
int [,,] array = new int[m,n,k];
int counter = 1;
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        for(int h =0;h<k;h++)
        {
            
            array[i,j,h] = numbers[counter-1];
            counter++;
            Console.Write($"{array[i,j,h]} ({i},{j},{h}) ");
        }
        Console.WriteLine();
    }
}
