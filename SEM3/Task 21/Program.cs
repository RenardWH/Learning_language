/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Введите координаты первой точки (3 числа)");
double [] pointA = new double [3];
double [] pointB = new double [3];


for (int i = 0; i<3;i++)
{
    pointA[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Введите координаты второй точки (3 числа)");


for (int i = 0; i<3;i++)
{
    pointB[i] = Convert.ToDouble(Console.ReadLine());
}
double lenght = 0;
for (int i = 0; i<3;i++)
{
    lenght = lenght + Math.Pow(pointB[i]-pointA[i], 2);
}
Console.WriteLine(Math.Sqrt(lenght));