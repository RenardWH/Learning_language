
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossPoint(double a1, double b1, double a2, double b2)
{
    double resultx = (b2-b1)/(a1-a2);
    double resulty = a1*resultx+b1;
    Console.WriteLine($"Координаты точки ({resultx};{resulty})");
}



Console.WriteLine("Введите кэффициент k1, уравнения  y = k1 * x + b1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кэффициент b1, уравнения  y = k1 * x + b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кэффициент k2, уравнения  y = k2 * x + b2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кэффициент b2, уравнения  y = k2 * x + b2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Вы задали два уровнения:");
Console.WriteLine($"y={k1}x + {b1}");
Console.WriteLine($"y={k2}x + {b2}");

if(k1==k2&&b1==b2)
{
    Console.WriteLine("Прямые сопадают, все точки являеются точками пересечения");
}
else if(k1==k2)
{
    Console.WriteLine("Прямые параллельны, нет точек пересечения");
}
else
{
    CrossPoint( k1,  b1,  k2,  b2);
}
