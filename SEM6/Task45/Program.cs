// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int [] CopyArray (int [] arr,int [] newArray)
{
    int arrLength = arr.Length;
    for(int i = 0; i <arrLength;i++)
    {
        newArray[i] = arr[i];
    } 
    return newArray;
}

Random rand = new Random();
int size = rand.Next(0, 10);
int [] array = new int[size];
int [] nArray = new int[size];
for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(1, 10);
}
Console.WriteLine("Basic array "+ '[' + string.Join(" , ",array)+']');

CopyArray(array,nArray);

Console.WriteLine("New array "+ '[' + string.Join(" , ",nArray)+']');