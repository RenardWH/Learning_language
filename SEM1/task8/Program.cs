//-----------Задача 8--------------------
/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());


//-----------Для неотрицательного числа--------------------
/*
N = (N-N%2)/2;
int count = 1;

while(count <= N)
{
    Console.WriteLine(count*2);
    count++;
}
*/
//-----------Для любого целого числа-----------------------

int negative_N = -N;
int count = 0;
if(count < N)
{
    while(count < N)
    {
        count++;
         if (count%2 == 0)
         {
            Console.WriteLine(count);
         }            
        
    }
}
else
{
    while(count > N)
    {
        
         if (N%2 == 0)
         {
            Console.WriteLine(N);
         }   
         N++;
    }
}
