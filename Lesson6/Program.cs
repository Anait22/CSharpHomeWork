// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void PositiveNumbers()
{
    Console.Write("Какое количество чисел Вы желаете ввести? ");
    int m = Convert.ToInt32(Console.ReadLine()); 
    int count = 0;
    int current = 1;
    for(current = 1; current <= m; current++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
            count++;
    }
    Console.WriteLine($"Вы ввели числа больше 0 в количестве {count}");
} 
PositiveNumbers(); 
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint()
{    
    Console.Write("Введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    
    if(k1==k2)
    Console.WriteLine("Точек пересечения двух прямых нет");
    else
    {
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    Console.WriteLine($"Две прямые пересекаются в точке с координатами Х:{x} и Y:{y}");
    }

}
IntersectionPoint();
