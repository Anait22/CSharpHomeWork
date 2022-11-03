// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {                  
        array[i] = new Random().Next(100,1000);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int EvenCount(int[] array)
{
    int count = 0;
    
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);
int result = EvenCount(myArray);
Console.WriteLine("Количество четных чисел в массиве равно " + result);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
int SumOfOdd(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(i % 2 > 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);
int result = SumOfOdd(myArray);
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна " + result);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
/*
double[] CreateArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(size);
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double SubBetweenVal (double[] array)
{
    double sub = 0;
    double min = array[0];
    double max = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j] < min)
            min = array[j];
    }
    
    sub = max - min;
    return sub;
 }

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);
double result = SubBetweenVal(myArray);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна " + result);
*/