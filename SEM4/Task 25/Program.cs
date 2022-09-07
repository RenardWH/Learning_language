// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Использование Math.Pow и аналогов = незачёт

double Cycle (double a, int b)
{
    double mult = 1;
    for (int i =1;i<=b; i++)
    {
        mult = mult * a;
    }
    return mult;
}
Console.WriteLine("Введите число которое надо возвести в степень");
double Snumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень (натуральное число)");
int Mnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cycle(Snumber,Mnumber));