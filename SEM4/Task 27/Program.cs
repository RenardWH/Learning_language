// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


/* для Натуральных чисел 
Console.WriteLine("Введите число");
int Snumber = Convert.ToInt32(Console.ReadLine());
int tech = Snumber;
int i = 0;
while (Math.Abs(tech) > 0)
{
    tech = tech/10;
    i+=1;
    // Console.WriteLine(i);
    Console.WriteLine(tech);
}
int [] array = new int [i];

 tech = Snumber;
for (int m = 0; tech > 0; m++)
{
    array[m] = tech %10;
    tech = tech/10;
    // Console.WriteLine(i);
    // Console.WriteLine(tech);
}


void Cycle(int[] arro)
{
    int lenght = arro.Length;
    int sum = 0;
    for(int n = 0; n < lenght; n++)
    {
        sum = sum + arro[n];
    }
    Console.WriteLine(sum);
}
Console.WriteLine();
Cycle(array);
*/


// Для целых чисел
Console.WriteLine("Введите число");
double Snumber = Convert.ToInt32(Console.ReadLine());
string Stext = Convert.ToString(Snumber);
int size = Stext.Length;
int negative = 0;

if (String.Compare(Convert.ToString(Stext[0]),"-") == 0)
{
     size = size -1;
     negative = 1;
}

Stext = Stext.Replace("-","");

double [] array = new double [size];
for (int i =0; i<size; i++)
{
   array [i] = double.Parse(Stext[i].ToString());
}

if (negative == 1)
{
     array[0] = -array[0];
}
//  Console.WriteLine('[' + string.Join(" , ",array)+']');
double sum = 0;
for(int i = 0; i<size;i++)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);