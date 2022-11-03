   
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double x, double x1, double y, double y1, double z, double z1)
{
    double a = ((x1-x)*(x1-x));
    double b = ((y1-y)*(y1-y));
    double c = ((z1-z)*(z1-z));
    double num = Math.Sqrt(a+b+c);
    double result = Math.Round(num,2);
    return result;
}

Console.WriteLine("Введите координату х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDis = FindDistance(x, x1, y, y1, z, z1);
Console.WriteLine($"Искомое расстояние равно {findDis}"); 
*/

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void ShowCubs(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCubs(number);
*/