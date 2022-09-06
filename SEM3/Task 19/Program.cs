/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int [] array = new int [5];
string check = "Да";
string Snumber = Convert.ToString(Console.ReadLine());
for (int i =0; i<5; i++)
{
   array [i] = int.Parse(Snumber[i].ToString());
   Console.WriteLine(array[i]);
   
}
for (int i =0; i<5/2; i++)
{
   if (array [i] != array [array.Length -1 -i])
   {
    check = "Нет";
   }
}
//char Vnumber = Snumber[3];
Console.WriteLine(check);
