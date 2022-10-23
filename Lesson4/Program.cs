// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Exponent(double a, double b)
{
        double result = 1;
        result = Math.Pow(a,b);
        return result;
}

Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень числа: ");
double b = Convert.ToDouble(Console.ReadLine());

double exponent = Exponent(a,b);
Console.WriteLine(exponent);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetSumm(int number)
{
    int result = 0;
           
    while(number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
       
    return result;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int s = GetSumm(a);
Console.WriteLine($"Сумма цифр в числе {a} равна {s}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(size);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);  
*/

// Дополнительная задача: Напишите программу, которая задаёт массив, при этом запрашивая у пользователя элементы массива.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);  
*/












   
   


